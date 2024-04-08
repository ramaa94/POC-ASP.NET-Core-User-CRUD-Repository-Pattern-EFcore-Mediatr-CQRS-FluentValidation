


namespace UserAPI.BLL.Features.Commands.DeleteUser;

public class DeleteUserCommand : IRequest<Unit>
{
    public DeleteUserCommand( Guid userId)
    {
        UserID = userId;

    }

    public Guid UserID { get; set; }

}
