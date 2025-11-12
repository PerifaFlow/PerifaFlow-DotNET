using PerifaFlow.Domain.Enum;

namespace PerifaFlow.Application.DTOs.Request.Entregas;

public class CriarEntregaRequest
{
    public Guid UsuarioId { get; set; }
    public Guid MissaoId { get; set; }
    public TipoEntrega TipoEntrega { get; set; }  // texto | áudio | foto
    public string Conteudo { get; set; } = string.Empty;
}