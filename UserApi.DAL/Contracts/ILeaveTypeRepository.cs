
namespace UserApi.DAL.Contracts;
public interface ILeaveTypeRepository

{
    Task<IEnumerable<LeaveType>> GetAllAsync();
    Task<LeaveType> GetByIdAsync(int id);

    Task CreateAsync(LeaveType leaveType);
    Task UpdateAsync(LeaveType leaveType);
    Task DeleteAsync(int id);
    Task<bool> IsLeaveTypeUnique(string name);
}
