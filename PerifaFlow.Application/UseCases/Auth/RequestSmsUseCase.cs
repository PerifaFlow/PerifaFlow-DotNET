using PerifaFlow.Application.DTOs.Request.Auth;
using PerifaFlow.Application.Interfaces.Services;

namespace PerifaFlow.Application.UseCases.Auth;

public class RequestSmsUseCase
{
    private readonly ISmsService _smsService;

    public RequestSmsUseCase(ISmsService smsService)
    {
        _smsService = smsService;
    }

    public async Task<bool> ExecuteAsync(RequestSmsRequest request)
    {
        return await _smsService.EnviarCodigoAsync(request.Telefone);
    }
}