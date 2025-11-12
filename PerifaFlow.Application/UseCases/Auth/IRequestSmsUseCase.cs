using PerifaFlow.Application.DTOs.Request.Auth;

namespace PerifaFlow.Application.UseCases.Auth;

public interface IRequestSmsUseCase
{
    Task<bool> ExecuteAsync(RequestSmsRequest request);

}