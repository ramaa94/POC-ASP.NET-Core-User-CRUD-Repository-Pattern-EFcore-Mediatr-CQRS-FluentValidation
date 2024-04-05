

namespace UserApi.BLL.MappingProfiles;

internal class LeaveTypeProfile :Profile
{
    public LeaveTypeProfile()
    {
        CreateMap<LeaveTypeDto,LeaveType>().ReverseMap();
    }
}
