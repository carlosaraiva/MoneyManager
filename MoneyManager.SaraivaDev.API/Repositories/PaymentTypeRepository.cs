using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class PaymentTypeRepository : BaseRepository<PaymentTypeModel>
    {
        public PaymentTypeRepository(MoneyManagerContext context) : base(context)
        {

        }
    }
}
