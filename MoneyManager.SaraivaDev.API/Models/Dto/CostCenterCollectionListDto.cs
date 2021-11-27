using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyManager.SaraivaDev.API.Models.Dto
{
    public class CostCenterCollectionListDto
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string CostCenterFatherId { get; set; }
        public bool IsActive { get; set; }
    }
}
