

namespace UserAPI.Controllers;
//[ApiController]

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
        app.MapGet("/User/", GetAllUsers);
        //app.MapGet("/User/{id}", GetUserById);
        app.MapPut("/User/update/{id}", UpdateUser);
        app.MapDelete("/User/delete/{id}", DeleteUser);
    }
    //private async Task<IResult> CreateUser(User user)
    //{

    //    var command = new CreateUserCommand(user.Name, user.ContactNumber, user.Age, user.UserID, user.Email, user.PhonesNumber);
    //    var userId = await _mediator.Send(command);
    //    var Result = Results.Created($"/User/{userId}", $"User created with ID: {userId}");
    //    return Result;
    //}
    private async Task<IResult> CreateUser(CreateUserCommand User)
    {
        var userId = await _mediator.Send(User);
        var Result = Results.Created($"/User/{userId}", $"User created with ID: {userId}");
        return Result;
    }
    private async Task<IResult> DeleteUser(Guid userId)
    {
        var command = new DeleteUserCommand(userId);
        var success = await _mediator.Send(command);
        return Results.NoContent();

    }
    private async Task<IResult> UpdateUser(UpdateUserCommand User)
    {
        var success = await _mediator.Send(User); 
        var Resultat = Results.Ok();


        return Resultat;
    }
    //GET: api/<UserController>
    [HttpGet]
    private async Task<List<UsersDto>> GetAllUsers()
    {
        var query = new GetAllUsersQuery();
        var users = await _mediator.Send(query);
        return users;

    }
    //private async Task<IResult> GetAllUsers()
    //{
    //    var query = new GetAllUsersQuery();
    //    var users = await _mediator.Send(query);

    //    if (users == null || users.Count == 0)
    //        return Results.NotFound();

    //    return Results.Ok(users);
    //}
}
//public async Task<IResult> GetUserById(Guid userId)
//{
//    var query = new GetOneUser(userId);
//    var user = await _mediator.Send(query);

//    return Results.Ok(user);
//}
