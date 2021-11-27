using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoneyManager.SaraivaDev.API.Common;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;
using System;

namespace MoneyManager.SaraivaDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IService<CategoryModel> Service { get; set; }
        private IMapper Mapper { get; set; }
        public CategoryController(IService<CategoryModel> service, IService<AccountModel> accountService, IMapper mapper)
        {
            Service = service ??
                throw new ArgumentNullException(nameof(service));
            Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet("{categoryId}")]
        public IActionResult GetById([FromRoute] string categoryId)
        {
            var category = Service.GetByIdAsync(categoryId);

            return Ok(Mapper.Map<CategoryCollectionListDto>(category.Result));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CategoryForCreateDto forCreateDto)
        {
            
            if (!TryValidateModel(forCreateDto))
            {
                return BadRequest();
            }

            CategoryModel category = Mapper.Map<CategoryModel>(forCreateDto);
            category.EntryTypeFor = (Enums.EntryType)forCreateDto.EntityTypeFor;
            category.IsActive = true;
            var categoryCreated = Service.CreateAsync(category);
            var createdDto = Mapper.Map<CategoryCreatedDto>(categoryCreated.Result);
            return Ok(createdDto);
        }

        [HttpPut]
        public IActionResult Update([FromBody] CategoryForUpdateDto forUpdateDto)
        {
            if (!TryValidateModel(forUpdateDto))
            {
                return BadRequest();
            }

            CategoryModel category = Mapper.Map<CategoryModel>(forUpdateDto);
            Service.UpdateAsync(category);

            return Ok();
        }

        [HttpDelete("{categoryId}")]
        public IActionResult Delete([FromRoute]string categoryId)
        {
            var category = Service.GetByIdAsync(categoryId);
            if (category.Result == null)
                return BadRequest();

            Service.DeleteAsync(categoryId);

            return Ok();
        }
    }
}
