using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Infrastructure.Persistence.Mappings;

public class CodigoMapping : IEntityTypeConfiguration<CodigoVerificacao>
{
    public void Configure(EntityTypeBuilder<CodigoVerificacao> builder)
    {
        builder.ToTable("CodigoVerificacao");
    }
}