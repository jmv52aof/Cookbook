namespace Cookbook.Repositories;

using System.Data;
using Cookbook.Domain;
using Cookbook.Infrastructure;

public class RecipeRepository : IRecipeRepository
{
    private readonly CookbookDbContext _dbContext;

    public RecipeRepository( CookbookDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public List<Recipe> GetAll()
    {
        return _dbContext.Recipe.ToList();
    }

    public Recipe GetById( int id )
    {
        var recipe = _dbContext.Recipe.FirstOrDefault( x => x.Id == id );
        if ( recipe == null )
        {
            return new Recipe( 0, "", "", 0, 0 );
        }
        return recipe;
    }

    public void Add( Recipe recipe )
    {
        _dbContext.Recipe.Add( recipe );
    }
}
