using Microsoft.EntityFrameworkCore;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;
using PerifaFlow.Infrastructure.Contexts.MySql;

namespace PerifaFlow.Infrastructure.Persistence.Repositoryes.MysqlRepo;

public class UserRepository : Repository<User>, IUserMySqlRepository
{
    private readonly PerifaFlowContext _context;
    public UserRepository(PerifaFlowContext context) : base(context)
    {
        _context = context;
    }


    public Task<User?> ObterPorTelefoneAsync(string telefone)
    {
        
    }

    public Task<bool> ExisteTelefoneAsync(string telefone)
    {
        
    }
}