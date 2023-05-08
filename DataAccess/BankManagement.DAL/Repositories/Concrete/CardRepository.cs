using BankManagement.DAL.Contexts.Abstract;
using BankManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts.Concrete
{
    public class CardRepository : ICardRepository
    {
        private readonly BankDbContext _DbContext;
        public CardRepository(BankDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public IEnumerable<CardType> GetByBankId(int id)
        {
            IEnumerable<CardType> entity = _DbContext.CardTypes.Include(c => c.Bank).Where(t => t.BankId == id);
            return entity;
        }

        public CardType GetById(int id)
        {
            CardType entity = _DbContext.CardTypes.Include(c => c.Bank).FirstOrDefault(t => t.Id == id);
            return entity;
        }
    }
}
