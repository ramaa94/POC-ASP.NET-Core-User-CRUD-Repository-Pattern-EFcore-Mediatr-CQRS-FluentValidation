namespace UserApi.DAL.Models;


public class User : BaseEntity
{
 

    public string Name { get; set; } = "";
    public string? ContactNumber { get; set; }=string.Empty;

    public int Age { get; set; }
    public Guid UserID { get; set; }

    public string Email { get; set; } = string.Empty;

    public int PhonesNumber { get; set; }

    public int Nulll {  get; set; }


}