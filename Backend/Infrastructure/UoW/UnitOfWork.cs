namespace Cookbook.UnitOfWork;

using Cookbook.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly CookbookDbContext _dbContext;

    public UnitOfWork(CookbookDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Commit()
    {
        _dbContext.SaveChanges();
    }
}
