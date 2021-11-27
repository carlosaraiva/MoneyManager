using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class IdentityRoleClaimsRepositoryConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityRoleClaim<string>> modelBuilder)
        {
            modelBuilder.ToTable("RoleClaims");
        }
    }
}
