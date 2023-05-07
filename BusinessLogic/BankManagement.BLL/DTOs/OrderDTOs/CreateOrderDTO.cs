using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.DTOs.OrderDTOs
{
	public class CreateOrderDTO
	{
		public int UserId { get; set; }
		public int CardTypeId { get; set; }
	}
}
