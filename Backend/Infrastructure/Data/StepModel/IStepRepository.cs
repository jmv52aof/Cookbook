using Cookbook.Domain;

namespace Cookbook.Repositories;

public interface IStepRepository
{
    public List<Step> GetAllByRecipeId( int recipeId );
    public void Add( Step step );
}
