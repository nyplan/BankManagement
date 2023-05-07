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
    public class BankMapper : Profile
    {
        public BankMapper()
        {
            CreateMap<Bank,BankByIdDto>();
            CreateMap<Bank,BankToListDto>();
        }
    }
}
