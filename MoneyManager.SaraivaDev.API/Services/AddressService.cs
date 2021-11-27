using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class AddressService : BaseService<AddressModel>
    {
        public AddressService(IRepository<AddressModel> repository) : base(repository)
        {

        }
    }
}
