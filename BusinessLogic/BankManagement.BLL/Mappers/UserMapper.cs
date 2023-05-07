using AutoMapper;
using BankManagement.BLL.DTOs.UserDTOs;
using BankManagement.DAL.Entities;

namespace BankManagement.BLL.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserRegister, User>();
            CreateMap<User, UserLogin>();
        }
    }
}
