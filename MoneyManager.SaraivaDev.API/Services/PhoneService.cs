using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class PhoneService : BaseService<PhoneModel>
    {
        public PhoneService(IRepository<PhoneModel> repository) : base(repository) { }
    }
}
