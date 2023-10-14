using Domain.Common;

namespace Domain.Entities;

public class TelType : BaseAuditableEntity
{
    public TelType()
    {
        this.Tels = new HashSet<Tel>();
    }

    public string Name { get; set; } = string.Empty;

    public virtual IEnumerable<Tel> Tels { get; set; }
}
