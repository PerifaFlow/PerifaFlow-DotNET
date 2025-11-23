using PerifaFlowReal.Application.Dtos.Request;
using PerifaFlowReal.Application.Dtos.Response;
using PerifaFlowReal.Application.pagination;

namespace PerifaFlowReal.Application.UseCases.CreateUserUseCase;

public interface ICreateUserUseCase
{
    Task Execute(UserRequest request);
    
    
}