using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;
using System;

namespace MoneyManager.SaraivaDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostCenterController : ControllerBase
    {
        private IService<CostCenterModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public CostCenterController(IService<CostCenterModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{costCenterId}")]
        public IActionResult GetById([FromRoute] string costCenterId)
        {
            var costCenter = Service.GetByIdAsync(costCenterId);

            return Ok(Mapper.Map<CostCenterCollectionListDto>(costCenter.Result));
        }
    }
}
