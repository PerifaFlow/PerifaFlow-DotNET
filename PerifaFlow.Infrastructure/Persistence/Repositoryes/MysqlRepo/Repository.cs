using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Infrastructure.Contexts.MySql;

namespace PerifaFlow.Infrastructure.Persistence.Repositoryes.MysqlRepo;

public class Repository<T>: IRepository<T> where T : class
{
    private readonly PerifaFlowContext _context;
    private readonly DbSet<T> _dbSet;
    
    public Repository(PerifaFlowContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    
    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> ListAsync(int page = 1, int pageSize = 10)
    {
        return await _dbSet
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
}