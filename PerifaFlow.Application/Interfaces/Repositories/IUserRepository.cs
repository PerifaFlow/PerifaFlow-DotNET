using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Application.Interfaces.Repositories.Mongo;

public interface IUserRepository
{
    Task<User?> ObterPorIdAsync(Guid id);
    Task<User?> ObterPorTelefoneAsync(string telefone);
    Task<User> CriarAsync(User user);
    Task AtualizarAsync(User user);
    Task<IEnumerable<User>> ListarAsync(int page = 1, int pageSize = 10);
}