using PerifaFlow.Domain.Entities;
using PerifaFlowReal.Application.Dtos.Request;
using PerifaFlowReal.Application.pagination;

namespace PerifaFlowReal.Application.Interfaces.Repositories;

public interface IEntregaRepository : IRepository<Entrega>
{
    Task<PaginatedResult<EntregaSummary>> GetPageAsync(
        PageRequest page, 
        EntregaQuery? filter = null, 
        CancellationToken ct = default
    );
}