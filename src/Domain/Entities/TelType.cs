namespace Domain.Entities;

public class TelType
{
    public TelType()
    {
        this.Tels = new HashSet<Tel>();
    }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Status { get; set; }
    public virtual IEnumerable<Tel> Tels { get; set; }
}
