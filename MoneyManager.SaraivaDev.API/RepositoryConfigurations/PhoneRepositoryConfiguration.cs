using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class PhoneRepositoryConfiguration : IEntityTypeConfiguration<PhoneModel>
    {
        public void Configure(EntityTypeBuilder<PhoneModel> modelBuilder)
        {
            modelBuilder.ToTable("Phone");
            modelBuilder.HasOne(p => p.MMUser).WithMany(b => b.Phones).HasForeignKey("UserId");
        }
    }
}
