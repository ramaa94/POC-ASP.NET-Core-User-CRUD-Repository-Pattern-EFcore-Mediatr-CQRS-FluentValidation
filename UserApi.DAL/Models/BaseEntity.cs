namespace UserApi.DAL.Models;
public abstract class BaseEntity
{
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }

}
