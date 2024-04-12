namespace UserApi.BLL.Implementations;


public class LeaveTypeService : ILeaveTypeService
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public LeaveTypeService(ILeaveTypeRepository leaveTypeRepository)
    {
        _leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<IEnumerable<createLeaveTypeCommand>> GetAllLeaveTypesAsync()
    {
        return await _leaveTypeRepository.GetAllAsync();
    }

    public async Task<createLeaveTypeCommand> GetLeaveTypeByIdAsync(int id)
    {
        return await _leaveTypeRepository.GetByIdAsync(id);
    }

    public async Task CreateLeaveTypeAsync(createLeaveTypeCommand leaveType)
    {
        await _leaveTypeRepository.CreateAsync(leaveType);
    }

    public async Task UpdateLeaveTypeAsync(createLeaveTypeCommand leaveType)
    {
        await _leaveTypeRepository.UpdateAsync(leaveType);
    }

    public async Task DeleteLeaveTypeAsync(int id)
    {
        await _leaveTypeRepository.DeleteAsync(id);
    }
}
