using BankManagement.DAL.Contexts.Abstract;
using BankManagement.DAL.Entities;

namespace BankManagement.DAL.Contexts.Concrete
{
    public class CardRepository : ICardRepository
    {
        private readonly BankDbContext _DbContext;
        public CardRepository(BankDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public CardType GetByBankId(int id)
        {
            CardType entity = _DbContext.CardTypes.Where(t => t.BankId == id).First();
            return entity;
        }

        public CardType GetById(int id)
        {
            CardType entity = _DbContext.CardTypes.Where(t => t.Id == id).First();
            return entity;
        }
    }
}
