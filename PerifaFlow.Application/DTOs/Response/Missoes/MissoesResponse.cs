namespace PerifaFlow.Application.DTOs.Response.Missoes;

public class MissoesResponse
{
    public Guid Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public string Dificuldade { get; set; } = string.Empty;
    public int Pontuacao { get; set; }
    public bool Concluida { get; set; }
}