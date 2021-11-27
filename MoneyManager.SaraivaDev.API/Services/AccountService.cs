using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class AccountService : BaseService<AccountModel>
    {
        public AccountService(IRepository<AccountModel> repository) : base(repository)
        {

        }
    }
}
