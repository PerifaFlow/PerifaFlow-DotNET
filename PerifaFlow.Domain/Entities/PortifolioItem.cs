using PerifaFlow.Domain.Common;

namespace PerifaFlow.Domain.Entities;

public class PortifolioItem : BaseEntity
{
    public Guid UsuarioId { get; private set; }
    public string? Descricao { get; private set; }
    public ICollection<Entrega> Entregas { get; private set; } = new List<Entrega>();
    public string? UrlPublica { get; private set; }   
    public ICollection<string> Badges { get; private set; } = new List<string>();

    public PortifolioItem(string descricao, string urlPublica, Guid usuarioId)
    {
        Descricao = descricao;
        UrlPublica = urlPublica;
        UsuarioId = usuarioId;
    }
    
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