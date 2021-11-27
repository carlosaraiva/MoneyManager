using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class CostCenterModel : BaseModel
    {
        [Required]
        public string Description { get; set; }
        public string CostCenterFatherId { get; set; }
        public CostCenterModel CostCenter { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
