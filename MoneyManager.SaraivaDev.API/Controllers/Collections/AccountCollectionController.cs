using Microsoft.AspNetCore.Mvc;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using System;

namespace MoneyManager.SaraivaDev.API.Controllers.Collections
{
    [Route("api/[controller]/{userId}")]
    [ApiController]
    public class AccountCollectionController : ControllerBase
    {
        private IService<AccountModel> Service { get; set; }

        public AccountCollectionController(IService<AccountModel> service)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
        }
        
        [HttpGet]
        public IActionResult GetUserAccountCollection([FromRoute] string userId)
        {
            var list = Service.ListAsync(a => a.MMUser.Id == userId);
            return Ok(list.Result);
        }
    }
}
