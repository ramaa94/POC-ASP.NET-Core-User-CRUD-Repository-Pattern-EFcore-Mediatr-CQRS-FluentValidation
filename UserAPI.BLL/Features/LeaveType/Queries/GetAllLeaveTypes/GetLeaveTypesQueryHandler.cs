

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
 
public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    //dependency injection
    public GetLeaveTypesQueryHandler(IMapper mapper,ILeaveTypeRepository LeaveTypeRepository)
    {
        this._mapper = mapper;
        _leaveTypeRepository = LeaveTypeRepository;
    }
    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
    {
        //what we did 
        // query db,
        var leaveTypes = await _leaveTypeRepository.GetAllAsync();
        // convert data objs to dto objs,
       var data= _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        // return list of dto objects
        
        return data;
    }
}
