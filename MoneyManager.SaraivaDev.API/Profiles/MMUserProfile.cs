using AutoMapper;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;

namespace MoneyManager.SaraivaDev.API.Profiles
{
    public class MMUserProfile : Profile
    {
        public MMUserProfile()
        {
            CreateMap<MMUserModel, AuthenticationForRegisterDto>();
            CreateMap<AuthenticationForRegisterDto, MMUserModel>();
            CreateMap<MMUserModel, AuthenticationForRegisterAdminDto>();
            CreateMap<AuthenticationForRegisterAdminDto, MMUserModel>();
        }
    }
}
