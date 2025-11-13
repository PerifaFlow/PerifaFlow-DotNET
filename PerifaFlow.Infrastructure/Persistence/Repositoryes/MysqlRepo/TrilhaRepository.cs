using Microsoft.EntityFrameworkCore;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;
using PerifaFlow.Infrastructure.Contexts.MySql;

namespace PerifaFlow.Infrastructure.Persistence.Repositoryes.MysqlRepo;

public class TrilhaRepository(PerifaFlowContext context) : ITrilhaRepository
{
    private readonly PerifaFlowContext _context = context;


    public Task<IEnumerable<Trilha>> ListarAsync(int page, int pageSize)
    {
        
    }

    public Task<Trilha?> ObterPorIdAsync(Guid id)
    {
        
    }
}