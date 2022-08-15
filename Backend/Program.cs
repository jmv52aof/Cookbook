using Microsoft.EntityFrameworkCore;
using Cookbook.UnitOfWork;
using Cookbook.Repositories;
using Cookbook.Infrastructure;
using Cookbook.Services;

var builder = WebApplication.CreateBuilder( args );

builder.Services.AddControllers();

builder.Services.AddDbContext<CookbookDbContext>( ctx =>
{
    try
    {
        const string connectionString = @"Server=debian;Database=cookbook;User Id=sa;Password=a12345678A;";
        ctx.UseSqlServer(connectionString);
    }
    catch (Exception)
    {
    }
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IRecipeService, RecipeService>();

var app = builder.Build();
app.MapControllers();
app.Run();
