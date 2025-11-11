using PerifaFlow.Domain.Common;

namespace PerifaFlow.Domain.Entities;

public class Parceiro : BaseEntity
{
    public string Nome { get; private set; } = string.Empty;
    public string? Site { get; private set; }
    public string? Contato { get; private set; }
    public string? Descricao { get; private set; }
    public string Tipo { get; private set; } = "Empresa";
    public bool Ativo { get; private set; } = true;
    
    public ICollection<Vaga> Vagas { get; set; } = new List<Vaga>();

    public Parceiro(string nome, string site, string contato, string descricao, string tipo)
    {       
        Nome = nome;
        Site = site;
        Contato = contato;
        Descricao = descricao;
        Tipo = tipo;
        Ativo = false;
    }
}