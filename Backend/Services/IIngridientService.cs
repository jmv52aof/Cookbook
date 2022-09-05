namespace Cookbook.Services;

using Cookbook.Domain;

public interface IIngridientService
{
    public List<Ingridient> GetAllByRecipeId( int recipeId );
    public void Add( Ingridient ingridient );
}
