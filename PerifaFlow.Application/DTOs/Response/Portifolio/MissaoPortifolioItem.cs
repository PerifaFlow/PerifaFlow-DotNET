namespace PerifaFlow.Application.DTOs.Response.Portifolio;

public class MissaoPortifolioItem
{
    public string MissaoTitulo { get; set; } = string.Empty;
    public string TipoEntrega { get; set; } = string.Empty;
    public string Conteudo { get; set; } = string.Empty;
    public DateTime EnviadaEm { get; set; }
}