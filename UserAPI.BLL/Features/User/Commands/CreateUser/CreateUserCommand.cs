using MediatR;
using System;


public class CreateUserCommand : IRequest<Guid>
{
    public string Name { get; set; } = "";
    public string? ContactNumber { get; set; } = string.Empty;
    public int Age { get; set; }
    public Guid UserID { get; set; }
    public string Email { get; set; } = string.Empty;
    public int PhonesNumber { get; set; }
}
