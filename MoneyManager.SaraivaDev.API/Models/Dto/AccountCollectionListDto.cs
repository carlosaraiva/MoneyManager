using System;

namespace MoneyManager.SaraivaDev.API.Models.Dto
{
    public class AccountCollectionListDto
    {
        public string Id { get; set; }
        public string MMUserId { get; set; }
        public short AccountType { get; set; }
        public decimal InitialValue { get; set; }
        public DateTime InitialDate { get; set; }
        public string CurrencyId { get; set; }
        public string Name { get; set; }
        public string HolderName { get; set; }
        public string Code { get; set; }
        public string Agency { get; set; }
        public string Number { get; set; }
        public bool IsActive { get; set; }
    }
}
