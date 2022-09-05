using Cookbook.Domain;

namespace Cookbook.Repositories;

public interface IRecipeRepository
{
    public List<Recipe> GetAll();
    public Recipe GetById( int id );
    public void Add( Recipe recipe );
}
