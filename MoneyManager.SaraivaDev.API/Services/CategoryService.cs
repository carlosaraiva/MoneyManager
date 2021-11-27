using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class CategoryService : BaseService<CategoryModel>
    {
        public CategoryService(IRepository<CategoryModel> repository) : base(repository)
        {

        }
    }
}
