using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Infrastructure.Persistence.Mappings;

public class MissaoMapping : IEntityTypeConfiguration<Missao>
{
    public void Configure(EntityTypeBuilder<Missao> builder)
    {
        builder.ToTable("Missao");
    }
}