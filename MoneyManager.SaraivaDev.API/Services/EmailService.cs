using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class EmailService : BaseService<EmailModel>
    {
        public EmailService(IRepository<EmailModel> repository) : base(repository)
        {
        }
    }
}
