using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.SaraivaDev.API.Common;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.RepositoryConfigurations
{
    public class CategoryRepositoryConfiguration : IEntityTypeConfiguration<CategoryModel>
    {
        public void Configure(EntityTypeBuilder<CategoryModel> modelBuilder)
        {
            modelBuilder.ToTable("Category");
            modelBuilder.HasData(
                new CategoryModel() { Description = "House", EntryTypeFor = Enums.EntryType.Expense, IsActive = true },
                new CategoryModel() { Description = "Phone Bill", EntryTypeFor = Enums.EntryType.Expense, IsActive = true },
                new CategoryModel() { Description = "Car", EntryTypeFor = Enums.EntryType.Expense, IsActive = true },
                new CategoryModel() { Description = "Fuel", EntryTypeFor = Enums.EntryType.Expense, IsActive = true },
                new CategoryModel() { Description = "Salary", EntryTypeFor = Enums.EntryType.Income, IsActive = true },
                new CategoryModel() { Description = "Profit", EntryTypeFor = Enums.EntryType.Income, IsActive = true },
                new CategoryModel() { Description = "Bonus", EntryTypeFor = Enums.EntryType.Income, IsActive = true });
        }
    }
}
