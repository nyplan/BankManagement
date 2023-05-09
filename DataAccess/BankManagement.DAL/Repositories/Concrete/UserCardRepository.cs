using BankManagement.DAL.Contexts;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;

namespace BankManagement.DAL.Repositories.Concrete
{
    public class UserCardRepository : IUserCardRepository
    {
        private readonly BankDbContext _context;
        public UserCardRepository(BankDbContext context)
        {
            _context = context;
        }

        public void Add(UserCard usercard)
        {
            _context.UserCards.Add(usercard);
            _context.SaveChanges();
        }

        public bool Any(Func<UserCard, bool> predicate)
        {
            return _context.UserCards.Any(predicate);
        }

        public UserCard GetByOrderId(int id)
        {
            return _context.UserCards.Single(c => c.OrderId == id);
        }
    }
}
