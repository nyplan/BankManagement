using BankManagement.DAL.Entities.Common;


namespace BankManagement.DAL.Entities
{
	public class Bank:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<CardType> CardType { get; set; }
    }
}
