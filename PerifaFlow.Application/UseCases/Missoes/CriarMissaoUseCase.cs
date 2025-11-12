using PerifaFlow.Application.DTOs.Request.Entregas;
using PerifaFlow.Application.DTOs.Response.Missoes;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;

namespace PerifaFlow.Application.UseCases.Missoes;

public class CriarMissaoUseCase : ICriarMissaoUseCase
{
    private readonly IMissaoRepository _missaoRepository;

    public CriarMissaoUseCase(IMissaoRepository missaoRepository)
    {
        _missaoRepository = missaoRepository;
    }

    public async Task<MissoesResponse> ExecuteAsync(CriarMissaoRequest request)
    {
        var missao = new Domain.Entities.Missao(
            request.Titulo,
            request.Descricao,
            request.Ordem,
            request.XP,
            request.Dificuldade,
            request.Pontuacao,
            request.TrilhaId
        );

        await _missaoRepository.CriarAsync(missao);

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