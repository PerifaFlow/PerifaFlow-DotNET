namespace PerifaFlow.Application.DTOs.Response.Missoes;

public class MissoesResponse
{
    public Guid Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    
    public int Ordem { get; set; }
    public int XP { get; set; }
    public string Dificuldade { get; set; } = string.Empty;
    public int Pontuacao { get; set; }
    public bool Concluida { get; set; }
}