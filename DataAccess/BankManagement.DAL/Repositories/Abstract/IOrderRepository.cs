using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAL.Repositories.Abstract
{
	public interface IOrderRepository
	{
		public Order GetById(int id);
		public void Add(Order order);
		IEnumerable<Order> GetAll();
	}
}
