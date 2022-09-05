namespace Cookbook.Services;

using Cookbook.Domain;
using Cookbook.Dto;
using Cookbook.Repositories;
using Cookbook.UnitOfWork;

public class StepService : IStepService
{
    private readonly IStepRepository _stepRepository;
    private readonly IUnitOfWork _unitOfWork;

    public StepService( IStepRepository stepRepository, IUnitOfWork unitOfWork )
    {
        _stepRepository = stepRepository;
        _unitOfWork = unitOfWork;
    }

    public List<Step> GetAllByRecipeId( int recipeId )
    {
        var steps = _stepRepository.GetAllByRecipeId( recipeId );
        return steps;
    }

    public void Add( Step step )
    {
        _stepRepository.Add( step );
        _unitOfWork.Commit();
    }
}
