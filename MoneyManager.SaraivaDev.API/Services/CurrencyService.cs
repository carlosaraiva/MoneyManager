using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class CurrencyService : BaseService<CurrencyModel>
    {
        public CurrencyService(IRepository<CurrencyModel> repository) : base(repository)
        {
        }
    }
}
