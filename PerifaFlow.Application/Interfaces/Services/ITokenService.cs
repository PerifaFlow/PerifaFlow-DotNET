namespace PerifaFlow.Application.Interfaces.Services;

public interface ITokenService
{
    string GerarToken(Domain.Entities.User user);
    Guid? ValidarToken(string token);
}