using Domain.Common;

namespace Domain.Entities;

public class Info : BaseAuditableEntity
{
    public Info()
    {
        this.Members = new HashSet<Member>();
        this.Addresses = new HashSet<Address>();
        this.Tels = new HashSet<Tel>(); 
    }

    public string Name { get; set; } = string.Empty;
    public virtual IEnumerable<Member> Members { get; set; }
    public virtual IEnumerable<Address> Addresses { get; set; }
    public virtual IEnumerable<Tel> Tels { get; set; }

}
