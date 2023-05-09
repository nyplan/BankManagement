using BankManagement.DAL.Entities.Common;

namespace BankManagement.DAL.Entities
{
	public class OrderStatus:BaseEntity
	{
		public string StatusKey { get; set; }
		public string StatusValue { get; set; }
	}
}
