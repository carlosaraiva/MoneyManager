using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class CurrencyModel : BaseModel
    {
        [Required]
        public string InternationalCode { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
