namespace Cookbook.Repositories;

using System.Data;
using Cookbook.Domain;
using Cookbook.Infrastructure;

public class StepRepository : IStepRepository
{
    private readonly CookbookDbContext _dbContext;

    public StepRepository( CookbookDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public List<Step> GetAllByRecipeId( int recipeId )
    {
        return _dbContext.Step.ToList().Where( x => x.RecipeId == recipeId ).ToList();
    }

    public void Add( Step step )
    {
        _dbContext.Step.Add( step );
    }
}
