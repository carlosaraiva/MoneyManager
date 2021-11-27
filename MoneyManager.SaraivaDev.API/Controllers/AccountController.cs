using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;
using System;

namespace MoneyManager.SaraivaDev.API.Controllers
{
    [Route("api/[controller]/{userId}")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IService<AccountModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public AccountController(IService<AccountModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{accountId}")]
        public IActionResult Get([FromRoute] string userId, string accountId)
        {
            var account = Service.ListAsync(a => a.MMUser.Id == userId && a.Id == accountId);

            var accountDto = Mapper.Map<AccountCollectionListDto>(account.Result);
            return Ok(accountDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AccountForCreateDto forCreateDto, [FromRoute] string userId)
        {
            if (!TryValidateModel(forCreateDto))
            {
                return BadRequest();
            }

            AccountModel account = Mapper.Map<AccountModel>(forCreateDto);
            account.MMUserId = userId;
            var accountCreate = Service.CreateAsync(account);

            return Ok(accountCreate.Result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] AccountForUpdateDto model)
        {
            if (!TryValidateModel(model))
            {
                return BadRequest();
            }

            AccountModel account = Mapper.Map<AccountModel>(model);
            Service.UpdateAsync(account);

            return Ok();
        }

        [HttpDelete("{accountId}")]
        public IActionResult Delete([FromRoute] string accountId)
        {
            return Ok();
        }
    }
}
