using System;
using MediatR;
using AutoMapper;
using UserApi.DAL.Repositories.contracts;


public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _UserRepository;

    public DeleteUserCommandHandler(IMapper mapper ,IUserRepository UserRepository)
    {
        this._mapper = mapper;
        _UserRepository = UserRepository;
    }
    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {

        var UserToDelete = _mapper.Map<User>(request);
        await _UserRepository.DeleteAsyncUser(UserToDelete);


        return Unit.Value;
    }
}