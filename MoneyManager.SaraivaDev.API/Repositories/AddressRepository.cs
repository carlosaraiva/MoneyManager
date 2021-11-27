using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class AddressRepository : BaseRepository<AddressModel>
    {
        public AddressRepository(MoneyManagerContext context) : base(context)
        {

        }
    }
}
