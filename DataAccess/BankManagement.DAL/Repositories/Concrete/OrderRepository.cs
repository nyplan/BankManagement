using BankManagement.DAL.Contexts;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			order.StatusId=1;
			_ctx.Orders.Add(order);
			_ctx.SaveChanges();
		}
	}
}
