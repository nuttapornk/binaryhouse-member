using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class InfoConfig : IEntityTypeConfiguration<Info>
{
    public void Configure(EntityTypeBuilder<Info> builder)
    {
        builder.ToTable(nameof(Info));
        builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
    }
}
