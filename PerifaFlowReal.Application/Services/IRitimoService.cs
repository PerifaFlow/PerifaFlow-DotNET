using PerifaFlowReal.Application.Dtos.java;

namespace PerifaFlowReal.Application.Interfaces.Services;

public interface IRitimoService
{
    Task RegistrarAsync(RitmoRegistroDto request, string? bearerToken, CancellationToken ct = default);
    Task<IEnumerable<InsightDto>> ObterInsightsAsync(string bairro, DateTime de, DateTime ate, string? bearerToken, CancellationToken ct = default);
    Task<SugestaoMissaoResponse> SugerirMissaoAsync(SugestaoMissaoRequest request, string? bearerToken, CancellationToken ct = default);
}