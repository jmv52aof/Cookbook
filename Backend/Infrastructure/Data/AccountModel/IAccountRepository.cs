using Cookbook.Domain;

namespace Cookbook.Repositories;

public interface IAccountRepository
{
    public Account GetById( int id );
    public Account GetByLogin( string login );
    public void Add( Account account );
}
