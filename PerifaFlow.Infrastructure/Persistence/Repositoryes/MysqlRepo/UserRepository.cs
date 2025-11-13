using Microsoft.EntityFrameworkCore;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;
using PerifaFlow.Infrastructure.Contexts.MySql;

namespace PerifaFlow.Infrastructure.Persistence.Repositoryes.MysqlRepo;

public class UserRepository(PerifaFlowContext context) : IUserRepository
{
    private readonly PerifaFlowContext _context = context;
    public async Task<User?> ObterPorIdAsync(Guid id)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> ObterPorTelefoneAsync(string telefone)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Telefone == telefone);
    }

    public async Task<User> CriarAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task AtualizarAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<User>> ListarAsync(int page = 1, int pageSize = 10)
    {
        return await _context.Users
            .AsNoTracking()
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}