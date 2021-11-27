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
    public class CurrencyCollectionController : ControllerBase
    {
        private IService<CurrencyModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public CurrencyCollectionController(IService<CurrencyModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet]
        public IActionResult GetCurrencyCollection()
        {
            var list = Service.ListAsync();

            return Ok(Mapper.Map<IList<CurrencyCollectionListDto>>(list.Result));
        }

    }
}
