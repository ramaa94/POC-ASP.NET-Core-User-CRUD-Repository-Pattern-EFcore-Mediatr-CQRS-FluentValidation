

namespace UserAPI.BLL.Features.Commands.CreateUser;

public class CreateUserValidator : AbstractValidator<CreateUserCommand>

{

    public CreateUserValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(70).WithMessage("{PropertyName} must not exceed 70 characters");
        RuleFor(p => p.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email address.");
    }

   
}
