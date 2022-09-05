using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Cookbook.UnitOfWork;
using Cookbook.Repositories;
using Cookbook.Infrastructure;
using Cookbook.Services;
using Cookbook.Helpers;

var builder = WebApplication.CreateBuilder( args );

builder.Services.AddControllers();

builder.Services.AddDbContext<CookbookDbContext>( ctx =>
{
    try
    {
        string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        ctx.UseSqlServer(connectionString);
    }
    catch (Exception)
    {
    }
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IRecipeService, RecipeService>();

builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddScoped<IStepRepository, StepRepository>();
builder.Services.AddScoped<IStepService, StepService>();

builder.Services.AddScoped<IIngridientRepository, IngridientRepository>();
builder.Services.AddScoped<IIngridientService, IngridientService>();

builder.Services.AddDataProtection().UseCryptographicAlgorithms(
    new AuthenticatedEncryptorConfiguration
    {
        EncryptionAlgorithm = EncryptionAlgorithm.AES_256_CBC,
        ValidationAlgorithm = ValidationAlgorithm.HMACSHA256
    });
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = AuthOptions.ISSUER,
            ValidateAudience = true,
            ValidAudience = AuthOptions.AUDIENCE,
            ValidateLifetime = true,
            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            ValidateIssuerSigningKey = true,
        };
    });
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllers();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
app.Run();
