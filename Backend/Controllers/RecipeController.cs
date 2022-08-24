namespace Cookbook.Controllers;

using Microsoft.AspNetCore.Mvc;
using Cookbook.Services;
using Cookbook.Dto;
using Cookbook.Domain;

[ApiController]
public class RecipeController : ControllerBase
{
    private readonly IRecipeService _recipeService;

    public RecipeController( IRecipeService recipeService )
    {
        _recipeService = recipeService;
    }

    [HttpGet]
    [Route( "recipe" )]
    public IActionResult GetAll()
    {
        try
        {
            return Ok( _recipeService.GetAll()
                .ConvertAll( t => t.ConvertToRecipeDto() ) );
        }
        catch ( Exception ex )
        {
            return BadRequest( ex.Message );
        }
    }

    [HttpGet]
    [Route( "recipe/{id}" )]
    public IActionResult GetById( int id )
    {
        try
        {
            var recipe = _recipeService.GetById( id );
            return Ok( recipe.ConvertToRecipeDto() );
        }
        catch ( Exception ex )
        {
            return BadRequest( ex.Message );
        }
    }
}
