
namespace UserApi.DAL.Contracts;
public interface ILeaveTypeRepository

{
    Task<IEnumerable<createLeaveTypeCommand>> GetAllAsync();
    Task<createLeaveTypeCommand> GetByIdAsync(int id);

    Task CreateAsync(createLeaveTypeCommand leaveType);
    Task UpdateAsync(createLeaveTypeCommand leaveType);
    Task DeleteAsync(int id);
    Task<bool> IsLeaveTypeUnique(string name);
}
