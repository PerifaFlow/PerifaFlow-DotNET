using PerifaFlow.Domain.Common;
using PerifaFlow.Domain.Enum;

namespace PerifaFlow.Domain.Entities;

public class Entrega : BaseEntity   
{
    public TipoEntrega Tipo { get; private set; } = TipoEntrega.Texto;
    public string Conteudo { get; private set; } = string.Empty;
    public string? UrlMidia { get; private set; }
    public double? Nota { get; private set; }
    public bool Validada { get; private set; } = false;
    public DateTime DataEnvio { get; private set; } = DateTime.UtcNow;
    
    // FK
    public Guid UsuarioId { get; private set; }
    public Guid MissaoId { get; private set; }
    

    public Entrega(Guid usuarioId, Guid missaoId, TipoEntrega tipo, string conteudo, string? urlMidia = null)
    {
        UsuarioId = usuarioId;
        MissaoId = missaoId;
        Tipo = tipo;
        Conteudo = conteudo;
        UrlMidia = urlMidia;
        DataEnvio = DateTime.UtcNow;
        Validada = false;
    }
    
    public void Validar(double? nota = null)
    {
        Validada = true;
        Nota = nota;
    }
}