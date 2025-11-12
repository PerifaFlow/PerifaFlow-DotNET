using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Application.Interfaces.Repositories.Mongo;

public interface IMissaoRepository
{
    Task<Missao?> ObterPorIdAsync(Guid id);
    Task<IEnumerable<Missao>> ListarPorTrilhaAsync(Guid trilhaId);
    Task CriarAsync(Missao missao);
}