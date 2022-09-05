namespace Cookbook.Infrastructure.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cookbook.Domain;

public class StepMap : IEntityTypeConfiguration<Step>
{
    public void Configure( EntityTypeBuilder<Step> builder )
    {
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id ).ValueGeneratedOnAdd();
        builder.Property( x => x.Text ).HasMaxLength( 4000 ).IsRequired();
        builder.Property( x => x.RecipeId ).IsRequired();
    }
}
