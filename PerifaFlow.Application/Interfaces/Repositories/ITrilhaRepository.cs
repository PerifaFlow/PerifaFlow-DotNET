using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Application.Interfaces.Repositories.Mongo;

public interface ITrilhaRepository
{
    Task<IEnumerable<Trilha>> ListarAsync(int page, int pageSize);
    Task<Trilha?> ObterPorIdAsync(Guid id);
}