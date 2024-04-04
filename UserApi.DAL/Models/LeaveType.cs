using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Domain;

public class LeaveType : BaseEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string DefaultDays { get; set; } = string.Empty;
}
