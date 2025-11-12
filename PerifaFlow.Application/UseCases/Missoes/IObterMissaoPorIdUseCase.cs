using PerifaFlow.Application.DTOs.Response.Missoes;

namespace PerifaFlow.Application.UseCases.Missoes;

public interface IObterMissaoPorIdUseCase
{
    Task<MissoesResponse?> ExecuteAsync(Guid id);
}