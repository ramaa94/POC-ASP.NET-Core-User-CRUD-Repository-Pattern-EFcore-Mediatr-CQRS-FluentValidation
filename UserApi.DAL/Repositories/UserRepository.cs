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


   public async Task<bool> DeleteAsync(int id)
    {
    var user = await _context.Users.FindAsync(id);
    if (user == null) return false;

    _context.Users.Remove(user);
    return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsyncUser(User user)
    {
        var user1 = await _context.Users.FindAsync(user);
        if (user1 == null) return false;

        _context.Users.Remove(user);
        return await _context.SaveChangesAsync() > 0;
    }

    public EntityEntry<User> Entry(User user)
    {
        throw new NotImplementedException();
    }

    public async Task<List<User>> GetAllAsync()
    {
        var liste = await _context.Users.ToListAsync();
        return liste;
    }


    public async Task<User?> GetByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }

   
    public async Task<int> SaveChangesAsync()
    {
    return await _context.SaveChangesAsync();
    }


    public async Task<bool> UpdateAsync(User user)
    {
    _context.Users.Update(user);
    return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> IsUserUnique(Guid id)
    {
        var userExists =await _context.Users.FindAsync(id);
         return userExists == null;
        ;
    }
}