using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class AddressConfig : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable(nameof(Address));
        builder.Property(t=>t.InfoId).IsRequired();
        builder.Property(t=>t.AddressTypeId).IsRequired();
        builder.Property(t => t.Line1).HasMaxLength(100);
        builder.Property(t => t.Line2).HasMaxLength(100);

        builder.Property(t => t.DistrictName).HasMaxLength(100);
        builder.Property(t => t.SubDistrictName).HasMaxLength(100);
        builder.Property(t => t.ProvinceName).HasMaxLength(100);

        builder.Property(t => t.ZipCode)
            .HasColumnType("character")
            .HasMaxLength(5);        
    }
}
