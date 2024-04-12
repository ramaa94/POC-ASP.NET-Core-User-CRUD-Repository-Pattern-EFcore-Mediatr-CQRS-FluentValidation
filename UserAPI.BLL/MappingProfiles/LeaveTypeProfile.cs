

using UserAPI.BLL.Features.LeaveType.Queries.GetAllLeaveTypes;

namespace UserApi.BLL.MappingProfiles;

internal class LeaveTypeProfile :Profile
{
    public LeaveTypeProfile()
    {
        CreateMap<LeaveTypeDto,LeaveType>().ReverseMap();
        CreateMap<CreateLeaveTypeCommand, LeaveType>();

    }
}
