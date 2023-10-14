using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces.Database;

public interface IApplicationDbContext
{
    DbSet<Address> Addresses { get; }
    DbSet<AddressType> AddressesType { get; }
    DbSet<Info> Info { get; }
    DbSet<Member> Members { get; }
    DbSet<Role> Roles { get; }
    DbSet<Tel> Tels { get; }
    DbSet<TelType> TelTypes { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    
}
