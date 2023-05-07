using BankManagement.BLL.DTOs.UserDTOs;
using BankManagement.DAL.Entities;

namespace BankManagement.BLL.Services.Abstract
{
    public interface IUserService
    {
        void Register(UserRegister dto);
        UserLogin Login(UserLogin dto);
    }
}
