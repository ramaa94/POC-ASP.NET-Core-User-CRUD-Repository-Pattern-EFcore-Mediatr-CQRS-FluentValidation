

global using UserApi.BLL.Implementations;
global using UserApi.BLL.Interfaces;

global using UserApi.DAL.Contracts;
global using UserApi.DAL.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5240");


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependeny Injection of DbContext Class

builder.Services.AddDbContext<PocDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<ILeaveTypeService, LeaveTypeService>();

var app = builder.Build();


// Apply migrations

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<PocDbContext>();
    dbContext.Database.Migrate();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();




