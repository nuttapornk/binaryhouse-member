namespace Domain.Entities;

public class AddressType
{
    public AddressType()
    {
        this.Addresses = new HashSet<Address>();
    }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Status { get; set; }
    public virtual IEnumerable<Address> Addresses { get; set; }
}
