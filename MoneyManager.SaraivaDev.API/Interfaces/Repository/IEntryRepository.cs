using System.Threading.Tasks;

namespace MoneyManager.SaraivaDev.API.Interfaces.Repository
{
    public interface IEntryRepository<EntryModel> : IRepository<EntryModel>
    {
        Task CreateTransferAsync(EntryModel entryIn, EntryModel entryOut);
        Task GetByAccountIdAndEntryIdAsync(string accountId, string entryId);
    }
}
