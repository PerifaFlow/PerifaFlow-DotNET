namespace PerifaFlow.Application.Interfaces.Services;

public interface ISmsService
{
    Task<bool> EnviarCodigoAsync(string telefone);
    Task<bool> ValidarCodigoAsync(string telefone, string codigo);
}