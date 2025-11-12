using PerifaFlow.Application.DTOs.Response.Missoes;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;

namespace PerifaFlow.Application.UseCases.Missoes;

public class ObterMissaoUseCase : IObterMissaoPorIdUseCase
{
    private readonly IMissaoRepository _missaoRepository;

    public ObterMissaoUseCase(IMissaoRepository missaoRepository)
    {
        _missaoRepository = missaoRepository;
    }

    public async Task<MissoesResponse?> ExecuteAsync(Guid id)
    {
        var missao = await _missaoRepository.ObterPorIdAsync(id);
        if (missao is null) return null;

        return new MissoesResponse
        {
            Id = missao.Id,
            Titulo = missao.Titulo,
            Descricao = missao.Descricao,
            Dificuldade = missao.Dificuldade,
            Pontuacao = missao.Pontuacao
        };
    }
}