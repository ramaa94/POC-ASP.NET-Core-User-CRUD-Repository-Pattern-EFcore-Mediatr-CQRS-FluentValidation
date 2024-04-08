



using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace UserApi.BLL.Implementations;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        var liste = await _userRepository.GetAllAsync();
        return liste;
    }

    public async Task<User> GetUserByIdAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null)
        {
            throw new InvalidOperationException($"Utilisateur avec ID {id} introuvable.");
        }
        return user;
    }


    public async Task<User> AddUserAsync(User user)
    {
        var adduser = await _userRepository.CreateAsync(user);
        await _userRepository.SaveChangesAsync();
        return user;
    }

    public EntityEntry<User> Entry(User user)
    {
        return _userRepository.Entry(user);
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        _userRepository.Entry(user).State = EntityState.Modified;
        await _userRepository.SaveChangesAsync();
        return user;
    }

  
    public async Task DeleteUserAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null) throw new InvalidOperationException($"Utilisateur avec ID {id} introuvable.");

        await _userRepository.DeleteAsync(id);
        await _userRepository.SaveChangesAsync();
    }
}