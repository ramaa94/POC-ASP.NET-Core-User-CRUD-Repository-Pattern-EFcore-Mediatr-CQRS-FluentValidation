namespace UserAPI.BLL.Features.LeaveType.Commands.DeleteLeaveType

{
    internal class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public DeleteLeaveTypeCommandHandler(IMapper mapper ,ILeaveTypeRepository LeaveTypeRepository)
        {
            this._mapper = mapper;
            _leaveTypeRepository = LeaveTypeRepository;
        }
        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            
            var leaveTypeToDelete = _mapper.Map<UserApi.DAL.Models.LeaveType>(request);
            await _leaveTypeRepository.DeleteAsync(leaveTypeToDelete.Id);


            return Unit.Value;
        }
    }
}
