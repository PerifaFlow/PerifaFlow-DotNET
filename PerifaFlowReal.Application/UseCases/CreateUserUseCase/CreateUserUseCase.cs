using PerifaFlow.Domain.Entities;
using PerifaFlowReal.Application.Dtos.Request;
using PerifaFlowReal.Application.Dtos.Response;
using PerifaFlowReal.Application.Interfaces.Repositories;
using PerifaFlowReal.Application.pagination;

namespace PerifaFlowReal.Application.UseCases.CreateUserUseCase;

public class CreateUserUseCase(IUserRepository userRepository) : ICreateUserUseCase
{
    public async Task<UserResponse> Execute(UserRequest request)
    {
        var user = new User(
            request.Username,
            request.Email,
            request.Password
        );
        
        await userRepository.AddAsync(user);

        return new UserResponse(
            user.Id,
            user.Username,
            user.Email,
            user.Password
        );
    }

    public Task<PaginatedResult<UserSummary>> ExecuteAsync(PageRequest page, UserQuery? filter = null, CancellationToken ct = default)
    {
        return userRepository.GetPageAsync(page, filter, ct);
    }
}