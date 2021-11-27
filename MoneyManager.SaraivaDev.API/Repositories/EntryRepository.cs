using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;
using System.Threading.Tasks;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class EntryRepository : BaseRepository<EntryModel>, IEntryRepository<EntryModel>
    {
        public EntryRepository(MoneyManagerContext context) : base(context)
        {

        }

        public Task CreateTransferAsync(EntryModel entryIn, EntryModel entryOut)
        {
            return Task.CompletedTask;
        }

        public Task GetByAccountIdAndEntryIdAsync(string accountId, string entryId)
        {
            return Task.CompletedTask;
        }
    }
}
