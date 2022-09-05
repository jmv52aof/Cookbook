namespace Cookbook.Infrastructure.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cookbook.Domain;

public class AccountMap : IEntityTypeConfiguration<Account>
{
    public void Configure( EntityTypeBuilder<Account> builder )
    {
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Id ).ValueGeneratedOnAdd();
        builder.Property( x => x.Name ).HasMaxLength( 255 ).IsRequired();
        builder.Property( x => x.Login ).HasMaxLength( 255 ).IsRequired();
        builder.Property( x => x.Password ).HasMaxLength( 255 ).IsRequired();
    }
}
