namespace Cookbook.Domain;

public class Account
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Login { get; private set; }
    public string Password { get; private set; }

    public Account( int id, string name, string login, string password )
    {
        Id = id;
        Name = name;
        Login = login;
        Password = password;
    }
}
