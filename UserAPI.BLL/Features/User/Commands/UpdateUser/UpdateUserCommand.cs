



namespace UserAPI.BLL.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<Guid>
    {
        //public UpdateUserCommand( string newName, string newContactNumber, int newAge, string newEmail, int newPhonesNumber)
        //{
        //    NewName = newName;
        //    NewContactNumber = newContactNumber;
        //    NewAge = newAge;
        //    NewEmail = newEmail;
        //    NewPhonesNumber = newPhonesNumber;
        //}

        public Guid UserId { get; }
        public string NewName { get; }
        public string NewContactNumber { get; }
        public int NewAge { get; }
        public string NewEmail { get; }
        public int NewPhonesNumber { get; }
    }

}
