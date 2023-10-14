using Domain.Common;

namespace Domain.Entities;

public class AddressType : BaseAuditableEntity
{
    public AddressType()
    {
        this.Addresses = new HashSet<Address>();
    }
    public string Name { get; set; } = string.Empty;
    public virtual IEnumerable<Address> Addresses { get; set; }
}
