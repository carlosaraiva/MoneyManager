using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class IdentityRoleRepositoryConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> modelBuilder)
        {
            modelBuilder.ToTable("Role");
        }
    }
}
