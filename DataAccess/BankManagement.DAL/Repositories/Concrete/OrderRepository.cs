using BankManagement.DAL.Contexts;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;

namespace BankManagement.DAL.Repositories.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BankDbContext _ctx;
        public OrderRepository(BankDbContext context)
        {
            _ctx = context;
        }
        public void Add(Order order)
        {
            order.StatusId = 1;
            _ctx.Orders.Add(order);
            _ctx.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return _ctx.Orders;
        }

        public Order GetById(int id)
        {
            return _ctx.Orders.Where(t => t.Id == id).First();
        }

        public void Patch(Order order)
        {
            _ctx.Update(order);
            _ctx.SaveChanges();
        }
    }
}
