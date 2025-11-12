using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Application.UseCases.Portfolio;

public class ObterPortfolioPorUsuarioUseCase
{
    private readonly IPortfolioRepository _portfolioRepository;

    public ObterPortfolioPorUsuarioUseCase(IPortfolioRepository portfolioRepository)
    {
        _portfolioRepository = portfolioRepository;
    }

    public async Task<IEnumerable<Entrega>> ExecuteAsync(Guid usuarioId)
    {
        if (usuarioId == Guid.Empty)
            throw new ArgumentException("ID de usuário inválido.");

        var entregas = await _portfolioRepository.ObterPorUsuarioAsync(usuarioId);

        if (entregas == null || !entregas.Any())
            throw new KeyNotFoundException("Nenhuma entrega encontrada para este usuário.");

        return entregas;
    }
}