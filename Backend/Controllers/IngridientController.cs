namespace Cookbook.Controllers;

using Microsoft.AspNetCore.Mvc;
using Cookbook.Services;
using Cookbook.Dto;
using Cookbook.Domain;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

[ApiController]
public class IngridientController : ControllerBase
{
    private readonly IIngridientService _ingridientService;

    public IngridientController( IIngridientService ingridientService )
    {
        _ingridientService = ingridientService;
    }

    [HttpGet]
    [Route( "ingridient/{recipeId}" )]
    public IActionResult GetAll( int recipeId )
    {
        try
        {
            return Ok( _ingridientService.GetAllByRecipeId( recipeId )
                .ConvertAll( t => t.ConvertToIngridientDto() ) );
        }
        catch ( Exception ex )
        {
            return BadRequest( ex.Message );
        }
    }

    [Authorize]
    [HttpPost]
    [Route( "ingridient/add" )]
    public IActionResult Add( [FromBody] IngridientDto ingridientDto )
    {
        try
        {
            var ingridient = ingridientDto.ConvertToIngridient();
            _ingridientService.Add( ingridient );
            return Ok( );
        }
        catch ( Exception ex )
        {
            return BadRequest( ex.Message );
        }
    }
}
