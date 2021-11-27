using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class IdentityUserRolesRepositoryConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> modelBuilder)
        {
            modelBuilder.ToTable("UserRoles");
        }
    }
}
