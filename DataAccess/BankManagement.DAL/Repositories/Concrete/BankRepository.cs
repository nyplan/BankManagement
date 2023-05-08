using BankManagement.DAL.Contexts;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Repositories.Concrete
{
    public class BankRepository:IBankRepository
    {
        private readonly BankDbContext _ctx;
        public BankRepository(BankDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Bank> Get()
        {
            return _ctx.Banks.ToList();
        }

        public Bank Get(int id)
        {
            return _ctx.Banks.Include(b => b.CardType).First(b => b.Id == id);
        }
    }
}
