namespace Cookbook.Infrastructure;

using Microsoft.EntityFrameworkCore;
using Cookbook.Domain;
using Cookbook.Infrastructure.Configurations;

public class CookbookDbContext : DbContext
{
    public DbSet<Recipe> Recipe { get; set; }
    public DbSet<Account> Account { get; set; }
    public DbSet<Ingridient> Ingridient { get; set; }
    public DbSet<Step> Step { get; set; }

    public CookbookDbContext( DbContextOptions options ) : base( options )
    {
    }

    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        modelBuilder.ApplyConfiguration( new RecipeMap() );
    }
}
