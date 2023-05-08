using BankManagement.DAL.Contexts;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

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
            _ctx.Orders.Add(order);
            _ctx.SaveChanges();
        }

        public IQueryable<Order> GetAll()
        {
            return _ctx.Orders.Include(c => c.User).Include(c => c.CardType).Include(c => c.OrderStatus);
        }

        public Order GetById(int id)
        {
            return _ctx.Orders.Find(id);
        }

        public void Patch(Order order)
        {
            _ctx.Update(order);
            _ctx.SaveChanges();
        }
    }
}
