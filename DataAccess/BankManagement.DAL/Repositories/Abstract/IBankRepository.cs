using BankManagement.DAL.Entities;

namespace BankManagement.DAL.Repositories.Abstract
{
    public interface IBankRepository
    {
        List<Bank> Get();
        Bank Get(int id);
    }
}
