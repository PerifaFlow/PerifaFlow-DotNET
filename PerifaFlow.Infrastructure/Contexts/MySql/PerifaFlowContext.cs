using Microsoft.EntityFrameworkCore;
using PerifaFlow.Domain.Entities;
using PerifaFlow.Infrastructure.Persistence.Mappings;

namespace PerifaFlow.Infrastructure.Contexts.MySql;

public class PerifaFlowContext(DbContextOptions<PerifaFlowContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Parceiro> Parceiros { get; set; }
    public DbSet<Entrega> Entregas { get; set; }
    public DbSet<Trilha> Trilhas { get; set; }
    public DbSet<Missao> Missao { get; set; }
    public DbSet<Vaga> Vagas { get; set; }
    public DbSet<PortifolioItem> PortifolioItems { get; set; }
    public DbSet<CodigoVerificacao> CodigoVerificacao { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new UserMapping());
        modelBuilder.ApplyConfiguration(new ParceiroMapping());
        modelBuilder.ApplyConfiguration(new EntregaMapping());
        modelBuilder.ApplyConfiguration(new TrilhaMapping());
        modelBuilder.ApplyConfiguration(new MissaoMapping());
        modelBuilder.ApplyConfiguration(new VagaMapping());
        modelBuilder.ApplyConfiguration(new PortfolioMapping());
        modelBuilder.ApplyConfiguration(new CodigoMapping());

    }
    
    
}
