namespace Cookbook.Services;

using Cookbook.Domain;

public interface IStepService
{
    public List<Step> GetAllByRecipeId( int recipeId );
    public void Add( Step step );
}
