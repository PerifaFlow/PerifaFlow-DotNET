using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Infrastructure.Persistence.Mappings;

public class TrilhaMapping : IEntityTypeConfiguration<Trilha>
{
    public void Configure(EntityTypeBuilder<Trilha> builder)
    {
        builder.ToTable("Trilha");
    }
}