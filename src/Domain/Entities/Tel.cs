using Domain.Common;

namespace Domain.Entities;

public class Tel : BaseAuditableEntity
{
    public Guid InfoId { get; set; }
    public Guid TelTypeId { get; set; }
    public string Number { get; set; } = string.Empty;
    public virtual Info? Info { get; set; }
    public virtual TelType? TelType { get; set; }
}
