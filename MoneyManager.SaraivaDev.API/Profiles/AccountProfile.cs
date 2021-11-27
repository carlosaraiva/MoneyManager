using AutoMapper;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;

namespace MoneyManager.SaraivaDev.API.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<AccountModel, AccountForCreateDto>();
            CreateMap<AccountForCreateDto, AccountModel>();
            CreateMap<AccountModel, AccountForUpdateDto>();
            CreateMap<AccountForUpdateDto, AccountModel>();
            CreateMap<AccountModel, AccountCollectionListDto>();
            CreateMap<AccountCollectionListDto, AccountModel>();
        }
    }
    //public class AccountMMUserResolver : IValueResolver<AccountCollectionListDto, AccountModel, MMUserModel>
    //{
    //    public MMUserModel Resolve(AccountCollectionListDto source, AccountModel destination, MMUserModel destMember, ResolutionContext context)
    //    {
    //        return new MMUserModel() { Id = source.MMUserId };
    //    }

    //}

    //public class AccountCurrencyResolver : IValueResolver<AccountCollectionListDto, AccountModel, CurrencyModel>
    //{
    //    public CurrencyModel Resolve(AccountCollectionListDto source, AccountModel destination, CurrencyModel destMember, ResolutionContext context)
    //    {
    //        return new CurrencyModel() { Id = source.CurrencyId };
    //    }

    //}
}
