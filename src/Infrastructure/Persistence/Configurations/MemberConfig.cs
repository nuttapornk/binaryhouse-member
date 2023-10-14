using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class MemberConfig : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.ToTable(nameof(Member));
        builder.Property(t=>t.Email).IsRequired().HasMaxLength(100);
        builder.Property(t=>t.FirstName).HasMaxLength(100);
        builder.Property(t => t.LastName).HasMaxLength(100);
    }
}
