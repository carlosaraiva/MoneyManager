using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.RepositoryConfigurations;
using System;

namespace MoneyManager.SaraivaDev.API.Contexts
{
    public class MoneyManagerContext : IdentityDbContext<MMUserModel>, IDataProtectionKeyContext
    {

        public MoneyManagerContext(DbContextOptions<MoneyManagerContext> options) : base(options)
        {

        }

        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }

        #region | DbSets

        #endregion | DbSets
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AddressRepositoryConfiguration());
            builder.ApplyConfiguration(new CostCenterRepositoryConfiguration());
            builder.ApplyConfiguration(new AccountRepositoryConfiguration());
            builder.ApplyConfiguration(new CurrencyRepositoryConfiguration());
            builder.ApplyConfiguration(new EmailRepositoryConfiguration());
            builder.ApplyConfiguration(new CategoryRepositoryConfiguration());
            builder.ApplyConfiguration(new EntryRepositoryConfiguration());
            builder.ApplyConfiguration(new IdentityRoleClaimsRepositoryConfiguration());
            builder.ApplyConfiguration(new IdentityRoleRepositoryConfiguration());
            builder.ApplyConfiguration(new IdentityUserClaimsRepositoryConfiguration());
            builder.ApplyConfiguration(new IdentityUserLoginRepositoryConfiguration());
            builder.ApplyConfiguration(new IdentityUserRolesRepositoryConfiguration());
            builder.ApplyConfiguration(new IdentityUserTokenRepositoryConfiguration());
            builder.ApplyConfiguration(new MMUserRepositoryConfiguration());
            builder.ApplyConfiguration(new MMUserRepositoryConfiguration());
            builder.ApplyConfiguration(new PaymentTypeRepositoryConfiguration());
            builder.ApplyConfiguration(new PhoneRepositoryConfiguration());
        }
    }
}
