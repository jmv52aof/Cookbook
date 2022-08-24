namespace Cookbook.Repositories;

using System.Data;
using Cookbook.Domain;
using Cookbook.Infrastructure;

public class AccountRepository : IAccountRepository
{
    private readonly CookbookDbContext _dbContext;

    public AccountRepository( CookbookDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public Account GetById( int id )
    {
        var account = _dbContext.Account.FirstOrDefault( x => x.Id == id );
        if ( account == null )
        {
            return new Account( 0, "", "", "" );
        }
        return account;
    }

    public Account GetByLogin( string login )
    {
        var account = _dbContext.Account.FirstOrDefault( x => x.Login == login );
        if ( account == null )
        {
            return new Account( 0, "", "", "" );
        }
        return account;
    }

    public void Add( Account account )
    {
        _dbContext.Account.Add( account );
    }
}
