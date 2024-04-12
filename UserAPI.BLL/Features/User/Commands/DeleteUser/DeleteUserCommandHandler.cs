namespace UserAPI.BLL.Features.Commands.DeleteUser;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _UserRepository;

    public DeleteUserCommandHandler(IMapper mapper, IUserRepository UserRepository)
    {
        _mapper = mapper;
        _UserRepository = UserRepository;
    }
    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {

        var UserToDelete = _mapper.Map<UserApi.DAL.Models.User>(request);
        await _UserRepository.DeleteAsync(UserToDelete.UserID);


        return Unit.Value;
    }
}