using MoneyManager.SaraivaDev.API.Common;

namespace MoneyManager.SaraivaDev.API.Models.Dto
{
    public class CategoryCollectionListDto
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public Enums.EntryType EntryTypeFor { get; set; }
        public CategoryCollectionListDto CategoryFather { get; set; }
        public bool IsActive { get; set; }
    }
}
