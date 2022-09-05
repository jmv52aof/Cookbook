namespace Cookbook.Services;

using Cookbook.Domain;

public interface IAccountService
{
    public Account GetById( int id );
    public Account GetByLogin( string login );
    public void Add( Account account );
}
