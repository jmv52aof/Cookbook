using Cookbook.Domain;

namespace Cookbook.Repositories;

public interface IIngridientRepository
{
    public List<Ingridient> GetAllByRecipeId( int recipeId );
    public void Add( Ingridient ingridient );
}
