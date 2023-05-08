using BankManagement.DAL.Entities;

namespace BankManagement.DAL.Contexts.Abstract
{
    public interface ICardRepository
    {
        IEnumerable<CardType> GetByBankId(int id);
        CardType GetById(int id);
    }
}
