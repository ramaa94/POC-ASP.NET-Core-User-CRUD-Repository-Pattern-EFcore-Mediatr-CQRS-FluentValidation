namespace UserAPI.BLL.Features.Commands.CreateUser;



public class CreateUserCommand : IRequest<Guid>
{
    //public CreateUserCommand(string name, string contactNumber, int age, Guid userId, string email, int phonesNumber)
    //{
    //    Name = name;
    //    ContactNumber = contactNumber;
    //    Age = age;
    //    UserID = userId;
    //    Email = email;
    //    PhonesNumber = phonesNumber;
    //}
    public string Name { get; set; } = "";
    public string? ContactNumber { get; set; } = string.Empty;
    public int Age { get; set; }
    public Guid UserID { get; set; }
    public string Email { get; set; } = string.Empty;
    public int PhonesNumber { get; set; }
}
