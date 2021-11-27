using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class IdentityUserLoginRepositoryConfiguration : IEntityTypeConfiguration<IdentityUserLogin<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> modelBuilder)
        {
            modelBuilder.ToTable("UserLogins");
        }
    }
}
