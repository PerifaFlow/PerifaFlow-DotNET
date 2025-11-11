namespace PerifaFlow.Application.DTOs.Request.Entregas;

public class CriarEntregaRequest
{
    public Guid UsuarioId { get; set; }
    public Guid MissaoId { get; set; }
    public string TipoEntrega { get; set; } = "texto"; // texto | áudio | foto
    public string Conteudo { get; set; } = string.Empty;
}