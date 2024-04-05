namespace UserApi.BLL.Interfaces;

public interface ILeaveTypeService
{
    Task<IEnumerable<LeaveType>> GetAllLeaveTypesAsync();
    Task<LeaveType> GetLeaveTypeByIdAsync(int id);
    Task CreateLeaveTypeAsync(LeaveType leaveType);
    Task UpdateLeaveTypeAsync(LeaveType leaveType);
    Task DeleteLeaveTypeAsync(int id);
}