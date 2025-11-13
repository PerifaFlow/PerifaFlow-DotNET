using MongoDB.Driver;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;
using PerifaFlow.Infrastructure.Contexts.MongoDB;

namespace PerifaFlow.Infrastructure.Persistence.Repositoryes.MongoRepo;

public class UserMongoRepository(MongoContext context) : IUserRepository
{
    private readonly IMongoCollection<User> _collection = context.Database.GetCollection<User>("Users");
    public async Task<User?> ObterPorIdAsync(Guid id)
    {
        return _collection.Find(u => u.Id == id).FirstOrDefault();
    }

    public async Task<User?> ObterPorTelefoneAsync(string telefone)
    {
        return _collection.Find(u => u.Telefone == telefone).FirstOrDefault();
    }

    public async Task<User> CriarAsync(User user)
    {
       await _collection.InsertOneAsync(user);
       return user;
    }

    public async Task AtualizarAsync(User user)
    {
        await _collection.ReplaceOneAsync(u => u.Email == user.Email, user);
    }

    public  Task<List<User>> ListarAsync(int page = 1, int pageSize = 10)
    {
        return  _collection.Find(u => true).ToListAsync();
    }
}