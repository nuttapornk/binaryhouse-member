using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class TelTypeConfig : IEntityTypeConfiguration<TelType>
{
    public void Configure(EntityTypeBuilder<TelType> builder)
    {
        builder.ToTable(nameof(TelType));

        builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
    }
}
