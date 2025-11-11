namespace PerifaFlow.Application.DTOs.Request.Entregas;

public class CriarMissaoRequest
{
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public string Dificuldade { get; set; } = string.Empty;
    public int Pontuacao { get; set; }
    public Guid TrilhaId { get; set; }
}