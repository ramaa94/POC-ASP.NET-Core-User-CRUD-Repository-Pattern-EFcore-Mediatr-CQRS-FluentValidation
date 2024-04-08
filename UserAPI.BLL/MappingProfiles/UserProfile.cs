using UserAPI.BLL.Features.User.query.GetAllUsers;

namespace UserApi.BLL.MappingProfiles;

internal class UserProfile :Profile
{
    public UserProfile()
    {
        CreateMap<UsersDto,User>().ReverseMap();
    }
}
