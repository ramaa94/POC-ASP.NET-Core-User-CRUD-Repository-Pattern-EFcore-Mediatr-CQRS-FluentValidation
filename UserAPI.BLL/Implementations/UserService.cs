




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
        return user;
    }


    public async Task<User> UpdateUserAsync(User user)
    {
        var updateuser = await _userRepository.UpdateAsync(user);
        return user;
    }

  
    public async Task DeleteAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null) throw new InvalidOperationException($"Utilisateur avec ID {id} introuvable.");

        await _userRepository.DeleteAsync(id);
    }

}
