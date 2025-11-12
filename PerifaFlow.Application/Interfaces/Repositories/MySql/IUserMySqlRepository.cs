using System.Linq.Expressions;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Application.Interfaces.Repositories.Mongo;

public interface IUserMySqlRepository : IRepository<User>
{
    Task<User?> ObterPorTelefoneAsync(string telefone);
    Task<bool> ExisteTelefoneAsync(string telefone);
}