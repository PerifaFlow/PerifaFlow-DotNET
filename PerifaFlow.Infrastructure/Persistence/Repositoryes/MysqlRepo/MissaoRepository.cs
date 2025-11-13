using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;
using PerifaFlow.Infrastructure.Contexts.MySql;

namespace PerifaFlow.Infrastructure.Persistence.Repositoryes.MysqlRepo;

public class MissaoRepository(PerifaFlowContext context) : IMissaoRepository
{
    private readonly PerifaFlowContext _context = context;

    public async Task<Missao?> ObterPorIdAsync(Guid id)
    {
        return await _context.Missao.FindAsync(id);
    }

    public async Task<IEnumerable<Missao>> ListarPorTrilhaAsync(Guid trilhaId)
    {
        return trilhaId;
    }

    public async Task CriarAsync(Missao missao)
    {
        return missao;
    }
}