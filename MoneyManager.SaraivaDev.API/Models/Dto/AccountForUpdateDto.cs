using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Dto
{
    public class AccountForUpdateDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public short AccountType { get; set; }
        [Required]
        public decimal InitialValue { get; set; }
        [Required]
        public DateTime InitialDate { get; set; }
        [Required]
        public Guid CurrencyId { get; set; }
        [Required]
        public string Name { get; set; }
        public string HolderName { get; set; }
        public string Code { get; set; }
        public string Agency { get; set; }
        public string Number { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
