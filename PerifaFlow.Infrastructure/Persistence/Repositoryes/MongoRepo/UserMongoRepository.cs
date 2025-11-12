using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Infrastructure.Persistence.Repositoryes.MongoRepo;

public class UserMongoRepository : IUserRepository
{
    public Task<User?> ObterPorIdAsync(Guid id)
    {
        
    }

    public Task<User?> ObterPorTelefoneAsync(string telefone)
    {
        
    }

    public Task<User> CriarAsync(User user)
    {
        
    }

    public Task AtualizarAsync(User user)
    {
        
    }

    public Task<IEnumerable<User>> ListarAsync(int page = 1, int pageSize = 10)
    {
        
    }
}