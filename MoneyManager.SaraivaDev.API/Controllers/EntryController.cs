using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;
using System;

namespace MoneyManager.SaraivaDev.API.Controllers
{
    [Route("api/[controller]/{accountId}")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        private IService<EntryModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public EntryController(IService<EntryModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet]
        public IActionResult List(string accountId)
        {
            var list = Service.ListAsync(e => e.Account.Id == accountId);

            return Ok(Mapper.Map<EntryCollectionListDto>(list.Result));
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] EntryForCreateDto forCreateDto, [FromRoute]string accountId)
        {
            if (!TryValidateModel(forCreateDto))
            {
                return BadRequest();
            }

            EntryModel entry = Mapper.Map<EntryModel>(forCreateDto);
            entry.AccountId = accountId;

            var entryCreated = Service.CreateAsync(entry);
            var createdDto = Mapper.Map<EntryCreatedDto>(entryCreated.Result);
            return Ok(createdDto);
        }

        [HttpPut]
        public IActionResult Update([FromBody] EntryForUpdateDto forUpdateDto)
        {
            if (!TryValidateModel(forUpdateDto))
            {
                return BadRequest();
            }

            EntryModel entry = Mapper.Map<EntryModel>(forUpdateDto);
            Service.UpdateAsync(entry);

            return Ok();
        }

        [HttpDelete("{entryId}")]
        public IActionResult Delete(string entryId)
        {
            var entry = Service.GetByIdAsync(entryId);
            if (entry.Result == null)
                return BadRequest();
            
            Service.DeleteAsync(entryId);

            return Ok();
        }
    }
}
