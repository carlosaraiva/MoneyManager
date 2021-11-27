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
    public class PaymentTypeCollectionController : ControllerBase
    {
        private IService<PaymentTypeModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public PaymentTypeCollectionController(IService<PaymentTypeModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet]
        public IActionResult GetAccountPaymentTypeCollection()
        {
            var list = Service.ListAsync();

            return Ok(Mapper.Map<IList<PaymentTypeCollectionListDto>>(list.Result));
        }
    }
}
