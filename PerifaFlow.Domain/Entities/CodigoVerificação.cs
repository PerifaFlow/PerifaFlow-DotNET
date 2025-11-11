using PerifaFlow.Domain.Common;

namespace PerifaFlow.Domain.Entities;

public class CodigoVerificação : BaseEntity
{
    public string Telefone { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public DateTime ExpiraEm { get; set; }
    public bool Utilizado { get; set; } = false;
    
    public bool EstaExpirado() => DateTime.UtcNow > ExpiraEm;

    public void MarcarComoUsado()
    {
        Utilizado = true;
    }
}