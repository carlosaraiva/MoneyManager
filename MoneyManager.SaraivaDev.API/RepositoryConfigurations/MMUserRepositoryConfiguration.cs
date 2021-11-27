using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class MMUserRepositoryConfiguration : IEntityTypeConfiguration<MMUserModel>
    {
        public void Configure(EntityTypeBuilder<MMUserModel> modelBuilder)
        {
            modelBuilder.ToTable("MMUser");
        }
    }
}
