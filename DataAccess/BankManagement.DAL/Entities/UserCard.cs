using BankManagement.DAL.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace BankManagement.DAL.Entities
{
    public class UserCard : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int CardId { get; set; }
        public CardType Card { get; set; }
        [MaxLength(16)]
        public int Number { get; set; }
        [MaxLength(3)]
        public int CVV { get; set; }
        [MaxLength(4)]
        public int Pincode { get; set; }
        [MaxLength(50)]
        public string OwnerName { get; set; }
    }
}
