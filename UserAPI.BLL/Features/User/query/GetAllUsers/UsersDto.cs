using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAPI.BLL.Features.User.query.GetAllUsers
{
    public class UsersDto
    {
        public Guid UserID { get; set; }

        public string Name { get; set; } = "";
        public string? ContactNumber { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Email { get; set; } = string.Empty;

        public int PhonesNumber { get; set; }

    }
}
