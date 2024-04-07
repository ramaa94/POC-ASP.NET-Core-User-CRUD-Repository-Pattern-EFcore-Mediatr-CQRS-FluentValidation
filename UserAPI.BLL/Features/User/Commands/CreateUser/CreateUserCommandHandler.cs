public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _UserRepository;

    public CreateUserCommandHandler(IMapper mapper  ,IUserRepository UserRepository)
    {
        this._mapper = mapper;
        this._UserRepository = UserRepository;
    }
    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        //validate data
        var validator = new CreateUserValidator(_UserRepository);
        var validationRes = await validator.ValidateAsync(request);
        //if (validationRes.Errors.Any()) 
        if (!validationRes.IsValid)
            throw new BadRequestException("Invalid type", validationRes);
        //convert
        var UserToCreate = _mapper.Map<User>(request);
        //add to db 
        await _UserRepository.CreateAsync(UserToCreate);
        // return record
        return UserToCreate.UserID;

    }


}
