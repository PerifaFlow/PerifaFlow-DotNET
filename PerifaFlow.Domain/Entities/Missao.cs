using PerifaFlow.Domain.Common;
using PerifaFlow.Domain.Enum;

namespace PerifaFlow.Domain.Entities;

public class Missao : BaseEntity
{
    public string Titulo { get; private set; } = string.Empty;
    public string Descricao { get; private set; } = string.Empty;
    public int Ordem { get; private set; }
    public int XP { get; private set; } = 50;
    public DateTime DataLiberacao { get; private set; } = DateTime.UtcNow;
    public StatusMissao Status { get; private set; } = StatusMissao.Disponivel;
    
    public Missao(string titulo, string descricao, int ordem, int xp, Guid trilhaId)
    {
        Titulo = titulo;
        Descricao = descricao;
        Ordem = ordem;
        XP = xp;
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