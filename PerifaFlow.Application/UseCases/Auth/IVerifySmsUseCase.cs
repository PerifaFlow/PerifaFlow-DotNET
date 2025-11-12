using PerifaFlow.Application.DTOs.Request.Auth;
using PerifaFlow.Application.DTOs.Response.Auth;

namespace PerifaFlow.Application.UseCases.Auth;

public interface IVerifySmsUseCase
{
    Task<AuthResponse> ExecuteAsync(VerifySmsRequest request);
}