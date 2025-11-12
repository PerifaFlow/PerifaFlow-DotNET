using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Application.Interfaces.Repositories.Mongo;

public interface IEntregaRepository
{
    Task<Entrega?> ObterPorIdAsync(Guid id);
    Task CriarAsync(Entrega entrega);
    Task<IEnumerable<Entrega>> ListarPorUsuarioAsync(Guid usuarioId);
}