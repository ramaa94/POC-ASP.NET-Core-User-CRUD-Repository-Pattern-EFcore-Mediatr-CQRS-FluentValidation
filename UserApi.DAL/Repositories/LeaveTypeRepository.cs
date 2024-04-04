
using HR.LeaveManagement.Domain;
using UserApi.DAL;

public class LeaveTypeRepository : ILeaveTypeRepository
{
    private readonly PocDbContext _context;

    public LeaveTypeRepository(PocDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<LeaveType>> GetAllAsync()
    {
        return await _context.LeaveTypes.ToListAsync();
    }

    public async Task<LeaveType> GetByIdAsync(int id)
    {
        return await _context.LeaveTypes.FindAsync(id);
    }

    public async Task CreateAsync(LeaveType leaveType)
    {
        await _context.LeaveTypes.AddAsync(leaveType);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(LeaveType leaveType)
    {
        _context.LeaveTypes.Update(leaveType);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var leaveType = await _context.LeaveTypes.FindAsync(id);
        if (leaveType != null)
        {
            _context.LeaveTypes.Remove(leaveType);
            await _context.SaveChangesAsync();
        }
    }

    public Task<bool> IsLeaveTypeUnique(string name)
    {
        throw new NotImplementedException();
    }
}