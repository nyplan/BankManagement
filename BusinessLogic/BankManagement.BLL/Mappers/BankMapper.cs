using AutoMapper;
using BankManagement.BLL.DTOs.BankDtos;
using BankManagement.DAL.Entities;

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
