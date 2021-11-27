using MoneyManager.SaraivaDev.API.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class EntryModel : BaseModel
    {
        [Required]
        public string AccountId { get; set; }
        public AccountModel Account { get; set; }
        [Required]
        public Enums.EntryType EntryType { get; set; }
        public DateTime? EntryConfirmedDate { get; set; }
        [Required]
        public DateTime EntryDate { get; set; }
        [Required]
        public decimal EntryValue { get; set; }
        public string CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public string CostCenterId { get; set; }
        public CostCenterModel CostCenter { get; set; }
        public string PaymentTypeId { get; set; }
        public PaymentTypeModel PaymentType { get; set; }

    }
}
