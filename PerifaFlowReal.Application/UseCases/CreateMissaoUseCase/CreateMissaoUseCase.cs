using PerifaFlowReal.Application.Dtos.java;
using PerifaFlowReal.Application.Dtos.Request;
using PerifaFlowReal.Application.Interfaces.Repositories;
using PerifaFlowReal.Application.pagination;

namespace PerifaFlowReal.Application.UseCases.CreateMissaoUseCase;

public class CreateMissaoUseCase(IMissaoRepository missaoRepository) : ICreateMissaoUseCase
{
    
    
    public Task<MissaoResponse> Execute(CreateMissaoUseCase useCase)
    {
        return MissaoRequest;
    }

    public Task<PaginatedResult<MissaoSummary>> GetPageAsync(PageRequest page, MissaoQuery? filter = null, CancellationToken ct = default)
    {
        return missaoRepository.GetPageAsync(page, filter, ct);
    }
}