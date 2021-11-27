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
    public class CurrencyController : ControllerBase
    {
        private IService<CurrencyModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public CurrencyController(IService<CurrencyModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet("{currencyId}")]
        public IActionResult GetById([FromRoute] string currencyId)
        {
            var currency = Service.GetByIdAsync(currencyId);

            return Ok(Mapper.Map<CurrencyCollectionListDto>(currency.Result));
        }
    }
}
