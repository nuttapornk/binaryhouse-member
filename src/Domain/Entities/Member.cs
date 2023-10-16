using Domain.Common;

namespace Domain.Entities;

public class Member : BaseAuditableEntity
{
    public Guid InfoId { get; set; }
    public int RoleId { get; set; }
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public virtual Info? Info { get; set; }
    public virtual Role? Role { get; set; }
}
