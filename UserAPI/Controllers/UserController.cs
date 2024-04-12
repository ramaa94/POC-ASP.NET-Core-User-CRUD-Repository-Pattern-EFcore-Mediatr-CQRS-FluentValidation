

using Microsoft.Extensions.DependencyInjection;

namespace UserAPI.Controllers;

public class UserController :ICarterModule
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public UserController(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;

    }

    public void AddRoutes(IEndpointRouteBuilder app)
    {

        app.MapPost("/User/create", CreateUser);
        app.MapGet("/User/", GetAllUsers);
        //app.MapGet("/User/{id}", GetUserById);
        app.MapPut("/User/update/{id}", UpdateUser);
        app.MapDelete("/User/delete/{id}", DeleteUser);
    }
    [HttpPost("/User/create")]
    private async Task<IResult> CreateUser(CreateUserCommand User)
    {
        using (var scope = _serviceScopeFactory.CreateScope())
        {
            var _mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
            var userId = await _mediator.Send(User);
            var Result = Results.Created($"/User/{userId}", $"User created with ID: {userId}");
            return Result;
        }
    }
    private async Task<IResult> DeleteUser(Guid userId)
    {
        using (var scope = _serviceScopeFactory.CreateScope())
        {
            var _mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
            var command = new DeleteUserCommand(userId);
            var success = await _mediator.Send(command);
            return Results.NoContent();
        }

    }
    private async Task<IResult> UpdateUser(UpdateUserCommand User)
    {
        using (var scope = _serviceScopeFactory.CreateScope())
        {
            var _mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
            var success = await _mediator.Send(User);
            var Resultat = Results.Ok();


            return Resultat;
        }
    }

    private async Task<IResult> GetAllUsers()
    {
        using (var scope = _serviceScopeFactory.CreateScope())
        {
            var _mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
            var query = new GetAllUsersQuery();
            var users = await _mediator.Send(query);

            return Results.Ok(users);
        }
    }
}
//public async Task<IResult> GetUserById(Guid userId)
//{
//    var query = new GetOneUser(userId);
//    var user = await _mediator.Send(query);

//    return Results.Ok(user);
//}
