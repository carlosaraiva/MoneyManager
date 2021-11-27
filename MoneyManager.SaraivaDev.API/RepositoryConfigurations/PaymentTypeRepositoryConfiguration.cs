using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Models.Domain;
using System;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class PaymentTypeRepositoryConfiguration : IEntityTypeConfiguration<PaymentTypeModel>
    {
        public void Configure(EntityTypeBuilder<PaymentTypeModel> modelBuilder)
        {
            modelBuilder.ToTable("PaymentType");
            modelBuilder.HasData(
                new PaymentTypeModel() { Description = "Bank Transfer", CreateDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true },
                new PaymentTypeModel() { Description = "Debit Card", CreateDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true },
                new PaymentTypeModel() { Description = "Credit Card", CreateDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true },
                new PaymentTypeModel() { Description = "Paycheck", CreateDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true });
        }
    }
}
