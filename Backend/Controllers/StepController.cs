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
public class StepController : ControllerBase
{
    private readonly IStepService _stepService;

    public StepController( IStepService stepService )
    {
        _stepService = stepService;
    }

    [HttpGet]
    [Route( "step/{recipeId}" )]
    public IActionResult GetAllByRecipeId( int recipeId )
    {
        try
        {
            return Ok( _stepService.GetAllByRecipeId( recipeId )
                .ConvertAll( t => t.ConvertToStepDto() ) );
        }
        catch ( Exception ex )
        {
            return BadRequest( ex.Message );
        }
    }

    [HttpPost]
    [Route( "step/add" )]
    public IActionResult Add( [FromBody] StepDto stepDto )
    {
        try
        {
            var step = stepDto.ConvertToStep();
            _stepService.Add( step );
            return Ok( );
        }
        catch ( Exception ex )
        {
            return BadRequest( ex.Message );
        }
    }
}
