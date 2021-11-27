using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Models.Domain;
using System;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class CostCenterRepositoryConfiguration : IEntityTypeConfiguration<CostCenterModel>
    {
        public void Configure(EntityTypeBuilder<CostCenterModel> modelBuilder)
        {
            modelBuilder.ToTable("CostCenter");
            modelBuilder.HasData(
                new CostCenterModel() { Description = "Home", IsActive = true, CreateDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new CostCenterModel() { Description = "Car", IsActive = true, CreateDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new CostCenterModel() { Description = "Savings", IsActive = true, CreateDate = DateTime.Now, ModifiedDate = DateTime.Now });
        }
    }
}
