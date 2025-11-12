using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Infrastructure.Persistence.Mappings;

public class VagaMapping : IEntityTypeConfiguration<Vaga>
{
    public void Configure(EntityTypeBuilder<Vaga> builder)
    {
        builder.ToTable("Vaga");
    }
}