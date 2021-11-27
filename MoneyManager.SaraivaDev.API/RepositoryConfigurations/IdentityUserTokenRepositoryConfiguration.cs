using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class IdentityUserTokenRepositoryConfiguration : IEntityTypeConfiguration<IdentityUserToken<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserToken<string>> modelBuilder)
        {
            modelBuilder.ToTable("UserToken");
        }
    }
}
