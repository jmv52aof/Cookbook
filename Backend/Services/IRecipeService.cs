namespace Cookbook.Services;

using Cookbook.Domain;

public interface IRecipeService
{
    public List<Recipe> GetAll();
    public Recipe GetById( int id );
    public void Add( Recipe recipe );
}
