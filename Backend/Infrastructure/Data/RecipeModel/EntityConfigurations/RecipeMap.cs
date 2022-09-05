namespace Cookbook.Infrastructure.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cookbook.Domain;

public class RecipeMap : IEntityTypeConfiguration<Recipe>
{
    public void Configure( EntityTypeBuilder<Recipe> builder )
    {
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id ).ValueGeneratedOnAdd();
        builder.Property( x => x.Name ).HasMaxLength( 255 ).IsRequired();
        builder.Property( x => x.ShortDescription ).HasMaxLength( 511 ).IsRequired();
        builder.Property( x => x.CookTimeMinutes ).IsRequired();
        builder.Property( x => x.Portions ).IsRequired();
    }
}
