using BankManagement.DAL.Entities.Common;

namespace BankManagement.DAL.Entities
{
	public class CardType : BaseEntity
	{
		public string Name { get; set; }
		public double Comission { get; set; }
		public double CashBack { get; set; }
		public double MaxCapacity { get; set; }
        public int ExpireYear { get; set; }
        public int BankId { get; set; }
		public Bank Bank { get; set; }
		public ICollection<UserCard> Users { get; set; }
	}
}
