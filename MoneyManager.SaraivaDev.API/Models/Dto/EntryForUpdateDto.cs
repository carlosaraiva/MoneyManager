using System;

namespace MoneyManager.SaraivaDev.API.Models.Dto
{
    public class EntryForUpdateDto
    {
        public DateTime EntryConfirmedDate { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal EntryValue { get; set; }
        public string CategoryId { get; set; }
        public string CostCenterId { get; set; }
        public string PaymentTypeId { get; set; }
    }
}
