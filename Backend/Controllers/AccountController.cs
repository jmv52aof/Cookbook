namespace Cookbook.Controllers;

using Microsoft.AspNetCore.Mvc;
using Cookbook.Services;
using Cookbook.Dto;
using Cookbook.Domain;
using Cookbook.Helpers;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;

[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController( IAccountService accountService )
    {
        _accountService = accountService;
    }

    [Authorize]
    [HttpGet]
    [Route( "account/get/{login}" )]
    public IActionResult GetAccount( string login )
    {
        try
        {
            var account = _accountService.GetByLogin( login );
            return Ok( account.ConvertToAccountDto() );
        }
        catch ( Exception ex )
        {
            return BadRequest( ex.Message );
        }
    }

    [HttpGet]
    [AllowAnonymous]
    [Route( "account/add/{name}/{login}/{password}" )]
    public IActionResult Add( string name, string login, string password )
    {
        try
        {
            var account = new Account( 0, name, login, password );
            _accountService.Add( account );
            return Ok( );
        }
        catch ( Exception ex )
        {
            return BadRequest( ex.Message );
        }
    }

    [HttpGet]
    [AllowAnonymous]
    [Route( "token/{login}/{password}" )]
    public IActionResult Token( string login, string password )
    {
        var account = GetIdentity( login, password );
        if (account == null)
        {
            return BadRequest( "Invalid username or password." );
        }

        var now = DateTime.UtcNow;
        var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                notBefore: now,
                claims: account.Claims,
                expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
        var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
        var response = new { token = encodedJwt };
        return Ok( JsonSerializer.Serialize(response) );
    }

    private ClaimsIdentity GetIdentity( string login, string password )
    {
        var account = _accountService.GetByLogin( login );
        if ( account == null || account.Password != password)
        {
            return null;
        }


        var claims = new List<Claim>
        {
            new Claim(ClaimsIdentity.DefaultNameClaimType, account.Login),
            //new Claim(ClaimsIdentity.DefaultRoleClaimType, account.Role)
        };
        ClaimsIdentity claimsIdentity =
        new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
            ClaimsIdentity.DefaultRoleClaimType);
        return claimsIdentity;
    }
}
