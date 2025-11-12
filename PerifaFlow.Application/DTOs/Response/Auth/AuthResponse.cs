namespace PerifaFlow.Application.DTOs.Response.Auth;

public class AuthResponse
{
    public string Token { get; set; } = string.Empty;
    public DateTime ExpiraEm { get; set; }
    public Guid UsuarioId { get; set; }
}