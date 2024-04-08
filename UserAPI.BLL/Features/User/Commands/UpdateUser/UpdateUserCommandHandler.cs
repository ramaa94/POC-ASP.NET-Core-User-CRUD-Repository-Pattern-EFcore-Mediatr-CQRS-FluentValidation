

namespace UserAPI.BLL.Features.User.Commands.UpdateUser;



public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public UpdateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<Guid> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        // Validate data (if needed)
        //var validator = new UpdateUserValidator(_userRepository);
        //var validationRes = await validator.ValidateAsync(request);
        //if (!validationRes.IsValid)
        //{
        //    throw new BadRequestException("Invalid update data", validationRes);
        //}

        // Retrieve the existing user from repository
        var UserToUpdate = await _userRepository.GetByIdAsync(request.UserId);
      

        // Map updated data to the existing user entity
        _mapper.Map(request, UserToUpdate);

        // Update the user in the repository
        await _userRepository.UpdateAsync(UserToUpdate);

        // Return the user ID
        return UserToUpdate.UserID;
    }
}
