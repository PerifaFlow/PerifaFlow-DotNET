using System.Linq.Expressions;

namespace PerifaFlow.Application.Interfaces.Repositories.Mongo;

public interface IRepository<T> where T : class
{
    Task<T?> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> ListAsync(int page = 1, int pageSize = 10);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}