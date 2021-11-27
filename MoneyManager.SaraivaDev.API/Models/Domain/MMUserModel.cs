using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class MMUserModel : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required, MaxLength(20)]
        public string TaxNumber { get; set; }
        [Required, MaxLength(20)]
        public string IdNumber { get; set; }
        public IList<AddressModel> Addresses { get; set; }
        public IList<PhoneModel> Phones { get; set; }
        public IList<EmailModel> Emails { get; set; }

    }
}
