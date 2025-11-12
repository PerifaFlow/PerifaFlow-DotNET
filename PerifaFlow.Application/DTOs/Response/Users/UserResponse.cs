namespace PerifaFlow.Application.DTOs.Response;

public class UserResponse
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public int RitmoScore { get; set; }
    public DateTime CriadoEm { get; set; }
}