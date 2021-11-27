using AutoMapper;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;

namespace MoneyManager.SaraivaDev.API.Profiles
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<CurrencyModel, CurrencyCollectionListDto>();
            CreateMap<CurrencyCollectionListDto, CurrencyModel>();
        }
    }
}
