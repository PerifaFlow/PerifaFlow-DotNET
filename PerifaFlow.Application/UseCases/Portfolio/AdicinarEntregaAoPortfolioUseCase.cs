using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;
using PerifaFlow.Domain.Enum;

namespace PerifaFlow.Application.UseCases.Portfolio;

public class AdicinarEntregaAoPortfolioUseCase
{
    private readonly IPortfolioRepository _portfolioRepository;
    private readonly IUserRepository _usuarioRepository;

    public AdicinarEntregaAoPortfolioUseCase(
        IPortfolioRepository portfolioRepository,
        IUserRepository usuarioRepository)
    {
        _portfolioRepository = portfolioRepository;
        _usuarioRepository = usuarioRepository;
    }

    public async Task<Guid> ExecuteAsync(Guid usuarioId, Guid missaoId, TipoEntrega tipo, string conteudo)
    {
        var usuario = await _usuarioRepository.ObterPorIdAsync(usuarioId);

        if (usuario == null)
            throw new KeyNotFoundException("Usuário não encontrado.");

        if (string.IsNullOrWhiteSpace(conteudo))
            throw new ArgumentException("Conteúdo da entrega é obrigatório.");

        var entrega = new Entrega(usuarioId, missaoId, tipo, conteudo);

        await _portfolioRepository.AdicionarAsync(entrega);
        return entrega.Id;
    }
}