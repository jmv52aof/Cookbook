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
        return _dbContext.Recipe.FirstOrDefault(x => x.Id == id);
    }
}
