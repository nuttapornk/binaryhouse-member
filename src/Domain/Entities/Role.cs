using Domain.Common;

namespace Domain.Entities;

public class Role : BaseAuditableEntity
{
    public Role()
    {
        this.Members = new HashSet<Member>();
    }
    public string Name { get; set; } = string.Empty;
    public virtual IEnumerable<Member> Members { get; set; }
}
