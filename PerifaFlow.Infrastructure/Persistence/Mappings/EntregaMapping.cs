using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Infrastructure.Persistence.Mappings;

public class EntregaMapping : IEntityTypeConfiguration<Entrega>
{
    public void Configure(EntityTypeBuilder<Entrega> builder)
    {
        builder.ToTable("Entrega");
    }
}