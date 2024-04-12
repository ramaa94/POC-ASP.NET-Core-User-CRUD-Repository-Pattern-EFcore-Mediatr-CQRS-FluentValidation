using UserAPI.BLL.Features.LeaveType.Queries.GetAllLeaveTypes;

namespace UserAPI.BLL.Features.LeaveType.Commands.CreateLeaveType;


public class CreateLeaveTypeValidator : AbstractValidator<CreateLeaveTypeCommand>

{

    public CreateLeaveTypeValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(70).WithMessage("{PropertyName} must not exceed 70 characters");
        RuleFor(p => p.DefaultDays)
.      LessThan(100).WithMessage("{PropertyName} cannot exceed 100")
.      GreaterThan(1).WithMessage("{PropertyName} cannot be less than 1");
        
    }

   
}
