using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application
{
    public class ErrorMessages
    {
        public static readonly Dictionary<string, string> Messages = new Dictionary<string, string>
    {
        { "Not_Valid", "the item not valid" },
        { "Not_Found", "the item not found" },

    };
    }
}
