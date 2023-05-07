using AutoMapper;
using BankManagement.BLL.DTOs.BankDtos;
using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.Mappers
{
    internal class BankmapperProfile:Profile
    {
        public BankmapperProfile()
        {
            CreateMap<Bank, BankToListDto>();
            CreateMap<Bank, BankByIdDto>();
        }
    }
}
