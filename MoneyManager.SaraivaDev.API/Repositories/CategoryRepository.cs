using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Models.Domain;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class CategoryRepository: BaseRepository<CategoryModel>
    {
        public CategoryRepository(MoneyManagerContext context) : base(context)
        {

        }
    }
}
