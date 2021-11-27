using MoneyManager.SaraivaDev.API.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class AddressModel: BaseModel
    {
        [Required]
        public string MMUserId { get; set; }
        public MMUserModel MMUser { get; set; }
        public Enums.AddressType? AddressType { get; set; }
        [Required]
        public bool PreferedMailing { get; set; }
        [Required, MaxLength(1000)]
        public string PublicPlace { get; set; }
        [Required, MaxLength(6)]
        public string Number { get; set; }
        [MaxLength(20)]
        public string Complement { get; set; }
        [Required, MaxLength(200)]
        public string Country { get; set; }
        [Required, MaxLength(200)]
        public string District { get; set; }
        [Required, MaxLength(200)]
        public string City { get; set; }
        [Required, MaxLength(10)]
        public string PostalCode { get; set; }

        
    }
}
