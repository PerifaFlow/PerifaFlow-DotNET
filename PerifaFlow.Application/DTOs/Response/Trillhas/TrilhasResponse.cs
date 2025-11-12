namespace PerifaFlow.Application.DTOs.Response.Trillhas;

public class TrilhasResponse
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public int TotalMissoes { get; set; }
}