using UserAPI.BLL.Features.User.query.GetAllUsers;


public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UsersDto>>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _UserRepository;

    //dependency injection
    public GetAllUsersQueryHandler(IMapper mapper, IUserRepository UserRepository)
    {
        this._mapper = mapper;
        _UserRepository = UserRepository;
    }
    public async Task<List<UsersDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        //what we did s
        // query db,
        var Users = await _UserRepository.GetAllAsync();
        // convert data objs to dto objs,
        var data = _mapper.Map<List<UsersDto>>(Users);
        // return list of dto objects
        return data;
    }
}
