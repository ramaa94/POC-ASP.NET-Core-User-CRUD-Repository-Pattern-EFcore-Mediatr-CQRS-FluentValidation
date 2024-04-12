namespace UserApi.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly PocDbContext _context;

    public UserRepository(PocDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateAsync(User user)
    {
        _context.Users.Add(user);
        return await _context.SaveChangesAsync() > 0;
    }


   public async Task<bool> DeleteAsync(Guid id)
    {
    var user = await _context.Users.FindAsync(id);
    if (user == null) return false;

    _context.Users.Remove(user);
    return await _context.SaveChangesAsync() > 0;
    }

 
    public async Task<List<User>> GetAllAsync()
    {
        var liste = await _context.Users.ToListAsync();
        return liste;
    }


    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await _context.Users.FindAsync(id);
    }

   
  

    public async Task<bool> UpdateAsync(User user)
    {
    _context.Users.Update(user);
    return await _context.SaveChangesAsync() > 0;
    }


}