using MoneyManager.SaraivaDev.API.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class AccountModel : BaseModel
    {
        [Required]
        public string MMUserId { get; set; }
        public MMUserModel MMUser { get; set; }
        [Required]
        public Enums.AccountType AccountType { get; set; }
        [Required]
        public decimal InitialValue { get; set; }
        [Required]
        public DateTime InitialDate { get; set; }
        [Required]
        public string CurrencyId { get; set; }
        public CurrencyModel Currency { get; set; }
        [Required]
        public string Name { get; set; }
        public string HolderName { get; set; }
        public string Code { get; set; }
        public string Agency { get; set; }
        public string Number { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public List<EntryModel> Entries { get; set; }
    }
}
