namespace Cookbook.Infrastructure.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cookbook.Domain;

public class IngridientMap : IEntityTypeConfiguration<Ingridient>
{
    public void Configure( EntityTypeBuilder<Ingridient> builder )
    {
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id ).ValueGeneratedOnAdd();
        builder.Property( x => x.Title ).HasMaxLength( 255 ).IsRequired();
        builder.Property( x => x.Text ).HasMaxLength( 4000 ).IsRequired();
        builder.Property( x => x.RecipeId ).IsRequired();
    }
}
