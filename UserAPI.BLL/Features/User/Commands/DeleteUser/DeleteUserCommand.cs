using System;
using MediatR;



public class DeleteUserCommand : IRequest<Unit>
{
    public Guid UserID { get; set; }

}
