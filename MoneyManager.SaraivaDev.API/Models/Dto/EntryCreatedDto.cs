﻿using MoneyManager.SaraivaDev.API.Common;
using System;

namespace MoneyManager.SaraivaDev.API.Models.Dto
{
    public class EntryCreatedDto
    {
        public string Id { get; set; }
        public string AccountId { get; set; }
        public Enums.EntryType EntryType { get; set; }
        public DateTime? EntryConfirmedDate { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal EntryValue { get; set; }
        public string CategoryId { get; set; }
        public string CostCenterId { get; set; }
        public string PaymentTypeId { get; set; }
    }
}
