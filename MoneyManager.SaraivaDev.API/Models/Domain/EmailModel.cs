using MoneyManager.SaraivaDev.API.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class EmailModel : BaseModel
    {
        [Required]
        public string MMUserId { get; set; }
        public MMUserModel MMUser { get; set; }
        public Enums.EmailType? EmailType { get; set; }
        [Required, MaxLength(600)]
        public string Email { get; set; }
        [Required]
        public bool PreferedEmail { get; set; }
        
    }
}
