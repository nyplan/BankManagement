using BankManagement.DAL.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAL.Entities
{
	public class Order:BaseEntity
	{
		public int UserId { get; set; }
		public User User { get; set; }
		public int CardTypeId { get; set; }
		public CardType CardType { get; set; }

		[ForeignKey("OrderStatus")]
		public int StatusId { get; set; }
		public OrderStatus OrderStatus { get; set; }
	}
}
