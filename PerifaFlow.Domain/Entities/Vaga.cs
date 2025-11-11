using PerifaFlow.Domain.Common;

namespace PerifaFlow.Domain.Entities;

public class Vaga: BaseEntity
{
    public string Titulo { get; private set; } = string.Empty;
    public string Descricao { get; private set; } = string.Empty;
    public string TipoContrato { get; private set; } = "Estágio";
    public string Localidade { get; private set; } = "Remoto";
    public decimal? Salario { get; private set; }
    public string? LinkInscricao { get; private set; }
    public bool Ativa { get; private set; } = true;
    
    public Guid ParceiroId { get; private set; }

    public Vaga(string titulo, string descricao, string tipoContrato, string localidade, decimal? salario, string linkInscricao
    , Guid parceiroId)
    {
        Titulo = titulo;
        Descricao = descricao;
        TipoContrato = tipoContrato;
        Localidade = localidade;
        Salario = salario;
        LinkInscricao = linkInscricao;
        Ativa = false;
        ParceiroId = parceiroId;
    }

    
}