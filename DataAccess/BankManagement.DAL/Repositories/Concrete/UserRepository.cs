using BankManagement.DAL.Contexts;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;

namespace BankManagement.DAL.Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly BankDbContext _context;
        public UserRepository(BankDbContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User Get(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
