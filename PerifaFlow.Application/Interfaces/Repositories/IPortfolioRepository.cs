using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Application.Interfaces.Repositories.Mongo;

public interface IPortfolioRepository
{
    Task<IEnumerable<Entrega>> ObterPorUsuarioAsync(Guid usuarioId);
    Task AdicionarAsync(Entrega entrega);
}