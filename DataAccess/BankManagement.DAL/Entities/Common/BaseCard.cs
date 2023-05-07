using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAL.Entities.Common
{
	public class BaseCard : BaseEntity
	{
		public string CardNumber { get; set; }
		public string CCV { get; set; }
		public string ExpirationDate { get; set; }
		public string OwnerName { get; set; }
	}
}
