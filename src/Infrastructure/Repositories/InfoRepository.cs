using Application.Common.Interfaces.Database;
using Application.Common.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class InfoRepository : IInfoRepository
{
    private readonly IApplicationDbContext _context;
    public InfoRepository(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Info> CreateAsync(Info info, CancellationToken cancellationToken)
    {
        _context.Info.Add(info);
        await _context.SaveChangesAsync(cancellationToken);
        return info;
    }

    public async Task<int> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var info = _context.Info.Find(id);
        if (info == null) return default;
        _context.Info.Remove(info);
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<Info>> FindAllAsync()
    {
        return await _context.Info.ToListAsync();
    }

    public async Task<Info?> FindById(Guid id)
    {
        return await _context.Info.FindAsync(id);
    }

    public async Task<Info> UpdateAsync(Info info, CancellationToken cancellationToken)
    {
        _context.Info.Update(info);
        await _context.SaveChangesAsync(cancellationToken);
        return info;
    }
}
