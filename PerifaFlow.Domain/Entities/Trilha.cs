using PerifaFlow.Domain.Common;
using PerifaFlow.Domain.Enum;

namespace PerifaFlow.Domain.Entities;

public class Trilha : BaseEntity
{
    public string Nome { get; private set; } = string.Empty;
    public string Descricao { get; private set; } = string.Empty;
    public TipoTrilha Tipo { get; private set; } = TipoTrilha.Geral;
    public int DuracaoDias { get; private set; }
    public string NivelDificuldade { get; private set; } = "Iniciante";
    public string Categoria { get; private set; } = "IA e Tecnologia";
    
    public ICollection<Missao> Missoes { get; set; } = new List<Missao>();

    public Trilha(string nome, string descricao, TipoTrilha tipo, 
        int duracaoDias, string nivelDificuldade, 
        string categoria )
    {
        Nome = nome;
        Descricao = descricao;
        Tipo = tipo;
        DuracaoDias = duracaoDias;
        NivelDificuldade = nivelDificuldade;
        Categoria = categoria;
    }
    
    
    public Missao? ObterProximaMissao(int ordemAtual)
        => Missoes.OrderBy(m => m.Ordem).FirstOrDefault(m => m.Ordem > ordemAtual);
}