using BankManagement.DAL.Entities;

namespace BankManagement.DAL.Repositories.Abstract
{
    public interface IUserCardRepository
    {
        void Add(UserCard usercard);
        UserCard GetByOrderId(int id);
        bool Any(Func<UserCard, bool> predicate);
    }
}
