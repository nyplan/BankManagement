using BankManagement.BLL.DTOs.OrderDTOs;
using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.Services.Abstract
{
	public interface IOrderService
	{
		public void Add(CreateOrderDTO dto);
	}
}
