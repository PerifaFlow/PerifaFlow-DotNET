using PerifaFlow.Domain.Common;
using PerifaFlow.Domain.Enum;

namespace PerifaFlow.Domain.Entities;

public class Missao : BaseEntity
{
    public string Titulo { get; private set; } = string.Empty;
    public string Descricao { get; private set; } = string.Empty;
    public int Ordem { get; private set; }
    public int XP { get; private set; } = 50;
    public int Pontuacao { get; private set; }
    public string Dificuldade { get; private set; }
    public DateTime DataLiberacao { get; private set; } = DateTime.UtcNow;
    public StatusMissao Status { get; private set; } = StatusMissao.Disponivel;
    
    public Missao(string titulo, string descricao, int ordem, int xp, string dificuldade, int pontuacao,Guid trilhaId)
    {
        Titulo = titulo;
        Descricao = descricao;
        Ordem = ordem;
        XP = xp;
        Dificuldade = dificuldade;
        Pontuacao = pontuacao;
        TrilhaId = trilhaId;
        Status = StatusMissao.Disponivel;
        DataLiberacao = DateTime.UtcNow;
    }

    

    // FK
    public Guid TrilhaId { get; private set; }
    public Trilha Trilha { get; private set; } = null!;
    

    public void Concluir()
    {
        Status = StatusMissao.Concluida;
    }
}