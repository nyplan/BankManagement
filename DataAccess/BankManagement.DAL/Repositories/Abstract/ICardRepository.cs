using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAL.Contexts.Abstract
{
    public interface ICardRepository
    {
        CardType GetByBankId(int id);
        CardType GetById(int id);
    }
}
