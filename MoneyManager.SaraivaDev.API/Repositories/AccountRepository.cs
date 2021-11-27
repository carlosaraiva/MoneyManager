using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class AccountRepository : BaseRepository<AccountModel>
    {
        public AccountRepository(MoneyManagerContext context) : base(context)
        { 
        }
    }
}
