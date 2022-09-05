namespace Cookbook.Services;

using Cookbook.Domain;
using Cookbook.Dto;
using Cookbook.Repositories;
using Cookbook.UnitOfWork;

public class RecipeService : IRecipeService
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RecipeService( IRecipeRepository recipeRepository, IUnitOfWork unitOfWork )
    {
        _recipeRepository = recipeRepository;
        _unitOfWork = unitOfWork;
    }

    public List<Recipe> GetAll()
    {
        var recipes = _recipeRepository.GetAll();
        _unitOfWork.Commit();
        return recipes;
    }

    public Recipe GetById( int id )
    {
        var recipe = _recipeRepository.GetById( id );
        _unitOfWork.Commit();
        return recipe;
    }

    public void Add( Recipe recipe )
    {
        _recipeRepository.Add( recipe );
        _unitOfWork.Commit();
    }
}
