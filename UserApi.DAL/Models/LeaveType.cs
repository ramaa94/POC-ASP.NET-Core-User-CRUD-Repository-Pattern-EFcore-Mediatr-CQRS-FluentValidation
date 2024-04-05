namespace UserApi.DAL.Models;

public class LeaveType : BaseEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string DefaultDays { get; set; } = string.Empty;
}
