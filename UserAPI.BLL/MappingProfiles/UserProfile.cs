namespace UserApi.BLL.MappingProfiles;

internal class UserProfile :Profile
{
    public UserProfile()
    {
        CreateMap<UsersDto,User>().ReverseMap();
    }
}
