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
    public class PaymentTypeController : ControllerBase
    {
        private IService<PaymentTypeModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public PaymentTypeController(IService<PaymentTypeModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet("{paymentTypeId}")]
        public IActionResult GetById([FromRoute]string paymentTypeId)
        {
            var paymentType = Service.GetByIdAsync(paymentTypeId);

            return Ok(Mapper.Map<PaymentTypeCollectionListDto>(paymentType.Result));
        }
    }
}
