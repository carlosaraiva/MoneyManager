using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class AccountRepositoryConfiguration : IEntityTypeConfiguration<AccountModel>
    {
        public void Configure(EntityTypeBuilder<AccountModel> modelBuilder)
        {
            modelBuilder.ToTable("Account");
            modelBuilder.HasOne(a => a.MMUser)
                        .WithMany();
            modelBuilder.HasOne(a => a.Currency)
                        .WithOne()
                        .HasForeignKey<AccountModel>(a => a.CurrencyId);
        }
    }
}
