namespace PerifaFlow.Application.DTOs.Response.Portifolio;

public class PortifoliResponse
{
    public Guid UsuarioId { get; set; }
    public string UsuarioNome { get; set; } = string.Empty;
    public List<MissaoPortifolioItem> Itens { get; set; } = new();
}

