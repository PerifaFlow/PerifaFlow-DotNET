using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Infrastructure.Persistence.Mappings;

public class ParceiroMapping : IEntityTypeConfiguration<Parceiro>
{
    public void Configure(EntityTypeBuilder<Parceiro> builder)
    {
        builder.ToTable("Parceiro");
    }
}