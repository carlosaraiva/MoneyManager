using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;
using System.Threading.Tasks;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class EntryService : BaseService<EntryModel>
    {
        private readonly IEntryRepository<EntryModel> _repository;
        public EntryService(IEntryRepository<EntryModel> repository) : base(repository) 
        {
            _repository = repository;
        }

        public Task CreateTransferAsync(EntryModel entryIn, EntryModel entryOut)
        {
            return _repository.CreateTransferAsync(entryIn, entryOut);

        }
    }
}
