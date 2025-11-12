using PerifaFlow.Application.DTOs.Request.Auth;
using PerifaFlow.Application.DTOs.Response.Auth;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Application.Interfaces.Services;

namespace PerifaFlow.Application.UseCases.Auth;

public class VerifyUseCase
{
    private readonly ISmsService _smsService;
    private readonly IUserRepository _usuarioRepository;
    private readonly ITokenService _tokenService;

    public VerifyUseCase(ISmsService smsService, IUserRepository usuarioRepository, ITokenService tokenService)
    {
        _smsService = smsService;
        _usuarioRepository = usuarioRepository;
        _tokenService = tokenService;
    }

    public async Task<AuthResponse> ExecuteAsync(VerifySmsRequest request)
    {
        var valid = await _smsService.ValidarCodigoAsync(request.Telefone, request.Codigo);
        if (!valid)
            throw new UnauthorizedAccessException("Código inválido.");

        var usuario = await _usuarioRepository.ObterPorTelefoneAsync(request.Telefone)
                      ?? await _usuarioRepository.CriarAsync(new Domain.Entities.User(request.Telefone));

        var token = _tokenService.GerarToken(usuario);

        return new AuthResponse
        {
            Token = token,
            ExpiraEm = DateTime.UtcNow.AddHours(6),
            UsuarioId = usuario.Id
        };
    }
}