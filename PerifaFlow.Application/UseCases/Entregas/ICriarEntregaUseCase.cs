using PerifaFlow.Application.DTOs.Request.Entregas;
using PerifaFlow.Application.DTOs.Response.Entrega;

namespace PerifaFlow.Application.UseCases.Entregas;

public interface ICriarEntregaUseCase
{
    Task<EntregaResponse> ExecuteAsync(CriarEntregaRequest request);
}