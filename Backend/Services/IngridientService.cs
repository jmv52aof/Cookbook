namespace Cookbook.Services;

using Cookbook.Domain;
using Cookbook.Dto;
using Cookbook.Repositories;
using Cookbook.UnitOfWork;

public class IngridientService : IIngridientService
{
    private readonly IIngridientRepository _ingridientRepository;
    private readonly IUnitOfWork _unitOfWork;

    public IngridientService( IIngridientRepository ingridientRepository, IUnitOfWork unitOfWork )
    {
        _ingridientRepository = ingridientRepository;
        _unitOfWork = unitOfWork;
    }

    public List<Ingridient> GetAllByRecipeId( int recipeId )
    {
        var ingridients = _ingridientRepository.GetAllByRecipeId( recipeId );
        return ingridients;
    }

    public void Add( Ingridient ingridient )
    {
        _ingridientRepository.Add( ingridient );
        _unitOfWork.Commit();
    }
}
