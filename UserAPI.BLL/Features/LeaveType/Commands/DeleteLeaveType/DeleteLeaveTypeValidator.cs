namespace UserAPI.BLL.Features.LeaveType.Commands.DeleteLeaveType

{
    public class DeleteLeaveTypeValidator:AbstractValidator<DeleteLeaveTypeCommand>
    {

        public DeleteLeaveTypeValidator()
        {
            RuleFor(p => p.Id)
                .NotNull();
        }
    }
}
