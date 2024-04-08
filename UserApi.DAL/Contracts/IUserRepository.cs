namespace UserApi.DAL.Contracts;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task<User?> GetByIdAsync(Guid id);
    Task<bool> CreateAsync(User user);
    Task<bool> UpdateAsync(User user);
    Task<bool> DeleteAsync(Guid id);

    Task<bool> DeleteAsyncUser(User user);
    Task<int> SaveChangesAsync();
    EntityEntry<User> Entry(User user);
   Task<bool> IsUserUnique(Guid id);


}
