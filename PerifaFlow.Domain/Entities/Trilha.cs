using PerifaFlow.Domain.Common;
using PerifaFlow.Domain.Enum;

namespace PerifaFlow.Domain.Entities;

public class Trilha : BaseEntity
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public TipoTrilha Tipo { get; set; } = TipoTrilha.Geral;
    public int DuracaoDias { get; set; }
    public string NivelDificuldade { get; set; } = "Iniciante";
    public string Categoria { get; set; } = "IA e Tecnologia";
    
    public ICollection<Missao> Missoes { get; set; } = new List<Missao>();
    
    public Missao? ObterProximaMissao(int ordemAtual)
        => Missoes.OrderBy(m => m.Ordem).FirstOrDefault(m => m.Ordem > ordemAtual);
}