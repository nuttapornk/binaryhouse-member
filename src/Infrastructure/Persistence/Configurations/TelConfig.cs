using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class TelConfig : IEntityTypeConfiguration<Tel>
{
    public void Configure(EntityTypeBuilder<Tel> builder)
    {
        builder.ToTable(nameof(Tel));

        builder.Property(t=>t.InfoId).IsRequired();
        builder.Property(t=>t.TelTypeId).IsRequired();
        builder.Property(t=>t.Number)
            .HasColumnType("character")
            .IsRequired()
            .HasMaxLength(10);
    }
}
