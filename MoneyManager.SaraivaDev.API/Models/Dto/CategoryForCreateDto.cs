using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Dto
{
    public class CategoryForCreateDto
    {
        [Required]
        public short EntityTypeFor { get; set; }
        [Required]
        public string Description { get; set; }
        public string CategoryFatherId { get; set; }
        public bool IsActive { get; set; }
    }
}
