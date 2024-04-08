namespace UserAPI.BLL.Features.LeaveType.Commands.DeleteLeaveType

{
    public class DeleteLeaveTypeValidator:AbstractValidator<DeleteLeaveTypeCommand>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public DeleteLeaveTypeValidator(ILeaveTypeRepository LeaveTypeRepository)
        {
            RuleFor(p => p.Id)
                .NotNull();
            this._leaveTypeRepository = LeaveTypeRepository;
        }
    }
}
