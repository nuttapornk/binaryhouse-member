using Application.Common.Interfaces.Database;
using Application.Common.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class MemberRepository : IMemberRepository
{
    private readonly IApplicationDbContext _context;

    public MemberRepository(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Member> CreateAsync(Member member, CancellationToken cancellationToken)
    {
        _context.Members.Add(member);
        await _context.SaveChangesAsync(cancellationToken);
        return member;
    }

    public async Task<bool> IsEmailEmpty(string email, CancellationToken cancellationToken)
    {
        return await _context.Members.AnyAsync(a => a.Email != email, cancellationToken);
    }
}
