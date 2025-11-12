using PerifaFlow.Domain.Common;

namespace PerifaFlow.Domain.Entities;

public class User : BaseEntity
{   
    public string Nome { get; private set; } = string.Empty;
    public string Telefone { get; private set; } = string.Empty;
    public string? Email { get; private set; }
    public string? Bio { get; private set; }
    public string? Localizacao { get; private set; }
    public string? AreaDeInteresse { get; private set; }

    public int Nivel { get; private set; } = 1;
    public int Experiencia { get; private set; } = 0;
    public double? RitmoMedio { get; private set; } // baseado nos RitmoScores anteriores
    public string? RitmoScoreAtual { get; private set; }

    // Relacionamentos
    public ICollection<Entrega> Entregas { get; private set; } = new List<Entrega>();
    public ICollection<Trilha> Trilhas { get; private set; } = new List<Trilha>();
    
    public User(string nome, string telefone, string? email = null, string? bio = null, string? localizacao = null, string? areaDeInteresse = null)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
        Bio = bio;
        Localizacao = localizacao;
        AreaDeInteresse = areaDeInteresse;
        Nivel = 1;
        Experiencia = 0;
        RitmoMedio = null;
    }

    public User(string telefone)
    {
        Telefone = telefone;
    }

    public void AdicionarExperiencia(int xp)
    {
        Experiencia += xp;
        if (Experiencia >= Nivel * 100)
        {
            Experiencia = 0;
            Nivel++;
        }
    }

    public void AtualizarRitmo(string novoScore)
    {
        RitmoScoreAtual = novoScore;
    }
    
}