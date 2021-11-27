using AutoMapper;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;

namespace MoneyManager.SaraivaDev.API.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryModel, CategoryCreatedDto>();
            CreateMap<CategoryCreatedDto, CategoryModel>();
            CreateMap<CategoryModel, CategoryForCreateDto>();
            CreateMap<CategoryForCreateDto, CategoryModel>();
            CreateMap<CategoryModel, CategoryForUpdateDto>();
            CreateMap<CategoryForUpdateDto, CategoryModel>();

            CreateMap<CategoryModel, CategoryCollectionListDto>();
            CreateMap<CategoryCollectionListDto, CategoryModel>();
        }
    }
}
