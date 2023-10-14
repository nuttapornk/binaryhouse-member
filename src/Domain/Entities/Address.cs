using Domain.Common;

namespace Domain.Entities;

public class Address : BaseAuditableEntity
{
    public Guid InfoId { get; set; }
    public Guid AddressTypeId { get; set; }
    public string Line1 { get; set; } = string.Empty;
    public string Line2 { get; set; } = string.Empty;
    public int DistrictId { get; set; }
    public string DistrictName { get; set; } = string.Empty;
    public int SubDistrictId { get; set; }
    public string SubDistrictName { get; set; } = string.Empty;
    public int ProvinceId { get; set; }
    public string ProvinceName { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public virtual Info? Info { get; set; }
    public virtual AddressType? AddressType { get; set; }
}
