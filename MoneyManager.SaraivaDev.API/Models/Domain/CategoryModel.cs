using MoneyManager.SaraivaDev.API.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class CategoryModel : BaseModel
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public Enums.EntryType EntryTypeFor { get; set; }
        public Guid CategoryFatherId { get; set; }
        public CategoryModel CategoryFather { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
