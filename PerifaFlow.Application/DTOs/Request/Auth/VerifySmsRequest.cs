namespace PerifaFlow.Application.DTOs.Request.Auth;

public class VerifySmsRequest
{
    public string Telefone { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
}