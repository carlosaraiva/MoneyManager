using AutoMapper;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;

namespace MoneyManager.SaraivaDev.API.Profiles
{
    public class PaymentTypeProfile : Profile
    {
        public PaymentTypeProfile()
        {
            CreateMap<PaymentTypeModel, PaymentTypeCollectionListDto>();
            CreateMap<PaymentTypeCollectionListDto, PaymentTypeModel>();
        }
    }
}
