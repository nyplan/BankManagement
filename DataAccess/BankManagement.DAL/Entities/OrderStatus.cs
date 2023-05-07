using BankManagement.DAL.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAL.Entities
{
	public class OrderStatus:BaseEntity
	{
		public string StatusKey { get; set; }
		public string StatusValue { get; set; }
	}
}
