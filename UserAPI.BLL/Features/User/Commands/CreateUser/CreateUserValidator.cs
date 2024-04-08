

namespace UserAPI.BLL.Features.Commands.CreateUser;

public class CreateUserValidator : AbstractValidator<CreateUserCommand>

{
    private readonly IUserRepository _userRepository;

    public CreateUserValidator(IUserRepository userRepository)
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(70).WithMessage("{PropertyName} must not exceed 70 characters");
        RuleFor(p => p.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email address.");
        RuleFor(p => p)
            .MustAsync(UserNameUnique)
            .WithMessage("alredy exists");
       this._userRepository = userRepository;
    }

    private  Task<bool> UserNameUnique(CreateUserCommand command, CancellationToken token)
    {
        return  _userRepository.IsUserUnique(command.UserID);
            }
}
