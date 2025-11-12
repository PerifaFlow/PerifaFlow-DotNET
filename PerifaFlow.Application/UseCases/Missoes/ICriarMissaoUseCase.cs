using PerifaFlow.Application.DTOs.Request.Entregas;
using PerifaFlow.Application.DTOs.Response.Missoes;

namespace PerifaFlow.Application.UseCases.Missoes;

public interface ICriarMissaoUseCase
{
    Task<MissoesResponse> ExecuteAsync(CriarMissaoRequest request);

}