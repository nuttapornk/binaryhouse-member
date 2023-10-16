using Domain.Entities;

namespace Application.Common.Interfaces.Repositories;

public interface IInfoRepository
{
    Task<IEnumerable<Info>> FindAllAsync();
    Task<Info?> FindById(Guid id);
    Task<Info> CreateAsync(Info info, CancellationToken cancellationToken);
    Task<Info> UpdateAsync(Info info, CancellationToken cancellationToken);
    Task<int> DeleteAsync(Guid id, CancellationToken cancellationToken);
}
