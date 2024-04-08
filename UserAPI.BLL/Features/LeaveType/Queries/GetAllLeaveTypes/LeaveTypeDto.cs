namespace  UserAPI.BLL.Features.LeaveType.Queries.GetAllLeaveTypes
{
    public class LeaveTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DefaultDays { get; set; } = string.Empty;
    }
}
