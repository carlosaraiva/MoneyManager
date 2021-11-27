using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;
using System;
using System.Collections.Generic;

namespace MoneyManager.SaraivaDev.API.Controllers.Collections
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostCenterCollectionController : ControllerBase
    {
        private IService<CostCenterModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public CostCenterCollectionController(IService<CostCenterModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet]
        public IActionResult GetAccountCostCenterCollection()
        {
            var list = Service.ListAsync();

            return Ok(Mapper.Map<IList<CostCenterCollectionListDto>>(list.Result));
        }
    }
}
