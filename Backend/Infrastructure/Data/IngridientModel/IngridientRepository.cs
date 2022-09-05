namespace Cookbook.Repositories;

using System.Data;
using Cookbook.Domain;
using Cookbook.Infrastructure;

public class IngridientRepository : IIngridientRepository
{
    private readonly CookbookDbContext _dbContext;

    public IngridientRepository( CookbookDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public List<Ingridient> GetAllByRecipeId( int recipeId )
    {
        return _dbContext.Ingridient.ToList().Where( x => x.RecipeId == recipeId ).ToList();
    }

    public void Add( Ingridient ingridient )
    {
        _dbContext.Ingridient.Add( ingridient );
    }
}
