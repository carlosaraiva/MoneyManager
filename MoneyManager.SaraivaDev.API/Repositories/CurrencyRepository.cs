using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class CurrencyRepository : BaseRepository<CurrencyModel>
    {
        public CurrencyRepository(MoneyManagerContext context) : base(context)
        {

        }
    }
}
