using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class PhoneRepository:BaseRepository<PhoneModel>
    {
        public PhoneRepository(MoneyManagerContext context):base(context)
        {

        }
    }
}
