using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class EntryRepositoryConfiguration : IEntityTypeConfiguration<EntryModel>
    {
        public void Configure(EntityTypeBuilder<EntryModel> modelBuilder)
        {
            modelBuilder.ToTable("Entry");
            modelBuilder.HasOne(e => e.Category)
                        .WithMany();
            modelBuilder.HasOne(e => e.CostCenter)
                        .WithMany();
            modelBuilder.HasOne(e => e.PaymentType)
                        .WithOne();
        }
    }
}
