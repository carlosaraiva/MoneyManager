using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;
using System;
using System.Collections.Generic;

namespace MoneyManager.SaraivaDev.API.Controllers.Collections
{
    [Route("api/[controller]/{accountId}")]
    [ApiController]
    public class EntryCollectionController : ControllerBase
    {
        private IService<EntryModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public EntryCollectionController(IService<EntryModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet]
        public IActionResult GetAccountEntryCollection([FromRoute] string accountId)
        {
            var list = Service.ListAsync(a => a.Account.Id == accountId);

            return Ok(Mapper.Map<IList<EntryCollectionListDto>>(list.Result));
        }
    }
}
