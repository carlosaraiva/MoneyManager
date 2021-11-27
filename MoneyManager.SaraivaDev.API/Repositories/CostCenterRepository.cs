using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class CostCenterRepository : BaseRepository<CostCenterModel>
    {
        public CostCenterRepository(MoneyManagerContext context) : base(context)
        { }
    }
}
