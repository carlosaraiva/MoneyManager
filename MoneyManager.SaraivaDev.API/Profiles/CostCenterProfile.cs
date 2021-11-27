using AutoMapper;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;

namespace MoneyManager.SaraivaDev.API.Profiles
{
    public class CostCenterProfile : Profile
    {
        public CostCenterProfile()
        {
            CreateMap<CostCenterModel, CostCenterCollectionListDto>();
            CreateMap<CostCenterCollectionListDto, CostCenterModel>();
        }
    }
}
