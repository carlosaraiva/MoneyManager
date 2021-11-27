using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class PaymentTypeService : BaseService<PaymentTypeModel>
    {
        public PaymentTypeService(IRepository<PaymentTypeModel> repository) : base(repository) { }
    }
}
