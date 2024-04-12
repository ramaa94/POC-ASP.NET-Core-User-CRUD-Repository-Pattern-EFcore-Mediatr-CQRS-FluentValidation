namespace UserApi.BLL.Interfaces;

public interface ILeaveTypeService
{
    Task<IEnumerable<createLeaveTypeCommand>> GetAllLeaveTypesAsync();
    Task<createLeaveTypeCommand> GetLeaveTypeByIdAsync(int id);
    Task CreateLeaveTypeAsync(createLeaveTypeCommand leaveType);
    Task UpdateLeaveTypeAsync(createLeaveTypeCommand leaveType);
    Task DeleteLeaveTypeAsync(int id);
}