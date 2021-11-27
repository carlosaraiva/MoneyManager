using AutoMapper;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Models.Dto;

namespace MoneyManager.SaraivaDev.API.Profiles
{
    public class EntryProfile:Profile
    {
        public EntryProfile()
        {
            CreateMap<EntryModel, EntryCollectionListDto>();
            CreateMap<EntryCollectionListDto, EntryModel>();
            CreateMap<EntryModel, EntryCreatedDto>();
            CreateMap<EntryCreatedDto, EntryModel>();
            CreateMap<EntryModel, EntryForCreateDto>();
            CreateMap<EntryForCreateDto, EntryModel>();
            CreateMap<EntryModel, EntryForUpdateDto>();
            CreateMap<EntryForUpdateDto, EntryModel>();
        }
    }
}
