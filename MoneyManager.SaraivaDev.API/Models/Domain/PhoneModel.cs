using MoneyManager.SaraivaDev.API.Common;
using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class PhoneModel : BaseModel
    {
        [Required]
        public string MMUserId { get; set; }
        [Required]
        public MMUserModel MMUser { get; set; }
        
        public Enums.PhoneType? PhoneType { get; set; }
        [Required, MaxLength(6)]
        public string CountryNumber { get; set; }
        [Required, MaxLength(6)]
        public string AreaNumber { get; set; }
        [Required]
        public bool PreferedNumber { get; set; }
    }
}
