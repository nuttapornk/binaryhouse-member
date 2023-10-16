using Domain.Entities;

namespace Application.Common.Interfaces.Repositories;

public interface IMemberRepository
{
    Task<Member> CreateAsync(Member member, CancellationToken cancellationToken);

    Task<bool> IsEmailEmpty(string email, CancellationToken cancellationToken);
}