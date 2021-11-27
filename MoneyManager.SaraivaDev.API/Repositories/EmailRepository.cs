using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class EmailRepository:BaseRepository<EmailModel>
    {
        public EmailRepository(MoneyManagerContext context) : base(context)
        {
        }
    }
}
