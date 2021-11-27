using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Models.Domain;
using System;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class CurrencyRepositoryConfiguration : IEntityTypeConfiguration<CurrencyModel>
    {
        public void Configure(EntityTypeBuilder<CurrencyModel> modelBuilder)
        {
            modelBuilder.ToTable("Currency");
            modelBuilder.HasData(
                new CurrencyModel() { InternationalCode = "EUR", Name = "EURO", CreateDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new CurrencyModel() { InternationalCode = "GBP", Name = "Pound Sterling", CreateDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new CurrencyModel() { InternationalCode = "USD", Name = "American Dollar", CreateDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new CurrencyModel() { InternationalCode = "BRL", Name = "Brazilian Real", CreateDate = DateTime.Now, ModifiedDate = DateTime.Now });
        }
    }
}
