using BankManagement.DAL.Entities;

namespace BankManagement.DAL.Repositories.Abstract
{
    public interface IUserRepository
    {
        void Add(User user);
        User Get(string username, string password);
    }
}
