namespace UserApi.DAL.Repositories;

public class LeaveTypeRepository : ILeaveTypeRepository
{
    private readonly PocDbContext _context;

    public LeaveTypeRepository(PocDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<createLeaveTypeCommand>> GetAllAsync()
    {
        return await _context.LeaveTypes.ToListAsync();
    }

    public async Task<createLeaveTypeCommand> GetByIdAsync(int id)
    {
        var leaveType = await _context.LeaveTypes.FindAsync(id); 
        if(leaveType is null) { throw new Exception(""); }
        return leaveType;
    }

    public async Task CreateAsync(createLeaveTypeCommand leaveType)
    {
        await _context.LeaveTypes.AddAsync(leaveType);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(createLeaveTypeCommand leaveType)
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