using Microsoft.EntityFrameworkCore;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;
using PerifaFlow.Infrastructure.Contexts.MySql;

namespace PerifaFlow.Infrastructure.Persistence.Repositoryes.MysqlRepo;

public class TrilhaRepository(PerifaFlowContext context) : ITrilhaRepository
{
    private readonly PerifaFlowContext _context = context;


    public async Task<IEnumerable<Trilha>> ListarAsync(int page, int pageSize)
    {
        return _context.Trilhas.AsNoTracking();
    }

    public async Task<Trilha?> ObterPorIdAsync(Guid id)
    {
        return await _context.Trilhas.FindAsync(id);
    }
}