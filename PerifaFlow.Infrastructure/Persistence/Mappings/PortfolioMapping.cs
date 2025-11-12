using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Infrastructure.Persistence.Mappings;

public class PortfolioMapping : IEntityTypeConfiguration<PortifolioItem>
{
    public void Configure(EntityTypeBuilder<PortifolioItem> builder)
    {
        builder.ToTable("Portifolio");
    }
}