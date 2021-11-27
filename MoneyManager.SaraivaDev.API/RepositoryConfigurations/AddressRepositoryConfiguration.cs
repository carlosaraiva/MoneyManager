using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class AddressRepositoryConfiguration : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> modelBuilder)
        {
            modelBuilder.ToTable("Address");
            modelBuilder.HasOne(p => p.MMUser).WithMany(b => b.Addresses).HasForeignKey("UserId");
        }
    }
}
