namespace Domain.Entities;

public class Role
{
    public Role()
    {
        this.Members = new HashSet<Member>();
    }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Status { get; set; }
    public virtual IEnumerable<Member> Members { get; set; }
}
