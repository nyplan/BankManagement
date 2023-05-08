using AutoMapper;
using BankManagement.BLL.DTOs.CardTypeDTOs;
using BankManagement.DAL.Entities;

namespace BankManagement.BLL.Mappers
{
    public class CardTypeMapper : Profile
    {
        public CardTypeMapper()
        {
            CreateMap<CardType, CardTypeByBankIdDto>()
                .ForMember(dest => dest.Bank, src => src.MapFrom(c => c.Bank.Name));
            CreateMap<CardType, CardTypeByIdDto>()
                .ForMember(dest => dest.Bank, src => src.MapFrom(c => c.Bank.Name));
            CreateMap<CardType, CardTypeToListDto>();
        }
    }
}
