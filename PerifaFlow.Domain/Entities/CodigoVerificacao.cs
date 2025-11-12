using PerifaFlow.Domain.Common;
using PerifaFlow.Domain.Enum;

namespace PerifaFlow.Domain.Entities;

public class CodigoVerificacao : BaseEntity
{
    public string Telefone { get; private set; } = string.Empty;
    public string Codigo { get; private set; } = string.Empty;
    public DateTime ExpiraEm { get; private set; }
    public bool Utilizado { get; private set; } = false;
    
    public bool EstaExpirado() => DateTime.UtcNow > ExpiraEm;

    public CodigoVerificacao(string telefone, string codigo)
    {
        Telefone = telefone;
        Codigo = codigo;
        Utilizado = false;
    }
    
    public void MarcarComoUsado()
    {
        Utilizado = true;
    }
}