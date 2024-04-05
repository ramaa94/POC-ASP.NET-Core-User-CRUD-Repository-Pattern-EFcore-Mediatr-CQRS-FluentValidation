namespace UserApi.BLL.Exceptions;

public class NotFoundException : Exception

{
    public NotFoundException(string name, Object key) : base($"{name} ({key}) was not found")
    {

    }
   
}
