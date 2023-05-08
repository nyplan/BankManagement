using BankManagement.BLL.DTOs.UserDTOs;

namespace BankManagement.BLL.Services.Abstract
{
    public interface IUserService
    {
        void Register(UserRegister dto);
        UserInfo Login(UserLogin dto);
    }
}
