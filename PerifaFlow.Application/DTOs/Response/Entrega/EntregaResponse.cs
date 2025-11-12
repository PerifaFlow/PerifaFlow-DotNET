namespace PerifaFlow.Application.DTOs.Response.Entrega;

public class EntregaResponse
{
    public Guid Id { get; set; }
    public Guid UsuarioId { get; set; }
    public Guid MissaoId { get; set; }
    public string TipoEntrega { get; set; } = string.Empty;
    public string Conteudo { get; set; } = string.Empty;
    public DateTime EnviadaEm { get; set; }
}