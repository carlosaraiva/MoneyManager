using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class CostCenterService : BaseService<CostCenterModel>
    {
        public CostCenterService(IRepository<CostCenterModel> repository) : base(repository)
        {

        }
    }
}
