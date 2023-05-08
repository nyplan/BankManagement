using BankManagement.DAL.Entities;

namespace BankManagement.DAL.Repositories.Abstract
{
    public interface IOrderRepository
    {
        public Order GetById(int id);
        public void Add(Order order);
        IEnumerable<Order> GetAll();
        public void Patch(Order order);
    }
}
