using AutoMapper;
using BankManagement.BLL.DTOs.CardTypeDTOs;
using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.Mappers
{
    public class CardTypeMapper : Profile
    {
        public CardTypeMapper()
        {
            CreateMap<CardType, CardTypeByBankIdDto>();
            CreateMap<CardType, CardTypeByIdDto>();
            CreateMap<CardType, CardTypeToListDto>();
        }
    }
}
