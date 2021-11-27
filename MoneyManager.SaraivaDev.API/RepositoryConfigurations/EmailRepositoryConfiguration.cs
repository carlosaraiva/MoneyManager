using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class EmailRepositoryConfiguration : IEntityTypeConfiguration<EmailModel>
    {
        public void Configure(EntityTypeBuilder<EmailModel> modelBuilder)
        {
            modelBuilder.ToTable("Email");
            modelBuilder.HasOne(p => p.MMUser).WithMany(b => b.Emails).HasForeignKey("UserId");
        }
    }
}
