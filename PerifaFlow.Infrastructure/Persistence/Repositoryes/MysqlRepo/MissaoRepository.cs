using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;
using PerifaFlow.Infrastructure.Contexts.MySql;

namespace PerifaFlow.Infrastructure.Persistence.Repositoryes.MysqlRepo;

public class MissaoRepository(PerifaFlowContext context) : IMissaoRepository
{
    private readonly PerifaFlowContext _context = context;

    public Task<Missao?> ObterPorIdAsync(Guid id)
    {
        
    }

    public Task<IEnumerable<Missao>> ListarPorTrilhaAsync(Guid trilhaId)
    {
       
    }

    public Task CriarAsync(Missao missao)
    {
        
    }
}