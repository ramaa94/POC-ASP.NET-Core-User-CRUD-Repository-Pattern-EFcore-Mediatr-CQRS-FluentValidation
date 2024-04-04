using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAPI.BLL.Features.User.query.GetAllUsers;

namespace HR.LeaveManagement.Application.MappingProfiles
{
    internal class UserProfile :Profile
    {
        public UserProfile()
        {
            CreateMap<UsersDto,User>().ReverseMap();
        }
    }
}
