
using Carter;
using MediatR;
using UserAPI.BLL.Features.Commands.CreateUser;
using UserAPI.BLL.Features.Commands.DeleteUser;
using UserAPI.BLL.Features.User.Commands.UpdateUser;
using UserAPI.BLL.Features.User.query.GetAllUsers;

namespace UserAPI.Controllers;

public class UserController : ControllerBase, ICarterModule
{
    private readonly PocDbContext _context;
    private readonly IMediator _mediator;

    public UserController(PocDbContext context, IMediator mediator)
    {
        _context = context;
        _mediator = mediator;

    }

    public void AddRoutes(IEndpointRouteBuilder app)
    {

        app.MapPost("/User/create", CreateUser);
        app.MapGet("/User/{id}", GetAllUsers);

        //app.MapGet("/User/{id}", GetUserById);
        app.MapPut("/User/update/{id}", UpdateUser);
        app.MapDelete("/User/delete/{id}", DeleteUser);
    }
    private async Task<IResult> CreateUser(User user)
    {

        var command = new CreateUserCommand(user.Name, user.ContactNumber, user.Age, user.UserID, user.Email, user.PhonesNumber);
        var userId = await _mediator.Send(command);
        var Result = Results.Created($"/User/{userId}", $"User created with ID: {userId}");
        return Result;
    }
    private async Task<IResult> DeleteUser(Guid userId)
    {
        var command = new DeleteUserCommand(userId);
        var success = await _mediator.Send(command);
        return Results.NoContent();

    }
    private async Task<IResult> UpdateUser(Guid UserId, User user)
    {
        var command = new UpdateUserCommand(user.Name, user.ContactNumber, user.Age, user.Email, user.PhonesNumber);
        var success = await _mediator.Send(command); // Send command to mediator
        var Resultat = Results.Ok();


        return Resultat;
    }
    private async Task<IResult> GetAllUsers()
    {
        var query = new GetAllUsersQuery();
        var users = await _mediator.Send(query);

        if (users == null || users.Count == 0)
            return Results.NotFound();

        return Results.Ok(users);
    }
}
    //private async Task<IResult> GetUserById(int userId)
    //{
    //    var query = new GetOneUser(userId);
    //    var user = await _mediator.Send(query);


//    if (user == null)
//        return Results.NotFound();

//    return Results.Ok(user);
//}
