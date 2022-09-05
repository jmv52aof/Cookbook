namespace Cookbook.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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

    [Authorize]
    [HttpPost]
    [Route( "recipe/add" )]
    public IActionResult Add( [FromBody] RecipeDto recipeDto )
    {
        try
        {
            var recipe = recipeDto.ConvertToRecipe();
            _recipeService.Add( recipe );
            return Ok( recipe.Id );
        }
        catch ( Exception ex )
        {
            return BadRequest( ex.Message );
        }
    }
}
