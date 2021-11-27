using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoneyManager.SaraivaDev.API.Common;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;
using System;
using System.Collections.Generic;

namespace MoneyManager.SaraivaDev.API.Controllers.Collections
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryCollectionController : ControllerBase
    {
        private IService<CategoryModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public CategoryCollectionController(IService<CategoryModel> service, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetAccountCategoryCollection([FromQuery] Enums.EntryType? entryTypeFor)
        {
            var list = Service.ListAsync(a => !entryTypeFor.HasValue || a.EntryTypeFor == entryTypeFor);

            return Ok(Mapper.Map<IList<CategoryCollectionListDto>>(list.Result));
        }
    }
}
