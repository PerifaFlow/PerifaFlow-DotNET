using PerifaFlow.Domain.Common;

namespace PerifaFlow.Domain.Entities;

public class PortifolioItem : BaseEntity
{
    public Guid UsuarioId { get; set; }
    public string? Descricao { get; set; }
    public ICollection<Entrega> Entregas { get; set; } = new List<Entrega>();
    public string? UrlPublica { get; set; }   
    public ICollection<string> Badges { get; private set; } = new List<string>();
    
    public void AdicionarEntrega(Entrega entrega)
    {
        if (!Entregas.Contains(entrega))
            Entregas.Add(entrega);
    }

    public void GerarUrlPublica(Guid usuarioId)
    {
        UrlPublica = $"https://perifaflow.app/portfolio/{usuarioId}";
    }

    public void AdicionarBadge(string badge)
    {
        if (!Badges.Contains(badge))
            Badges.Add(badge);
    }
}