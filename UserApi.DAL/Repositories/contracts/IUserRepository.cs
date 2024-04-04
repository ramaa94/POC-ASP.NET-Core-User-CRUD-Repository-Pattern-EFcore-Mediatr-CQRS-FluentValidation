

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace UserApi.DAL.Repositories.contracts;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task<User?> GetByIdAsync(int id);
    Task<bool> CreateAsync(User user);
    Task<bool> UpdateAsync(User user);
    Task<bool> DeleteAsync(int id);

    Task<bool> DeleteAsyncUser(User user);
    Task<int> SaveChangesAsync();
    EntityEntry<User> Entry(User user);
   Task<bool> IsUserUnique(Guid id);


}
