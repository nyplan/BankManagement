using BankManagement.DAL.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankManagement.DAL.Entities
{
    public class Order : BaseEntity
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
