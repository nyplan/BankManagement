
namespace BankManagement.BLL.DTOs.OrderDTOs
{
    public record AcceptedOrder : OrderDTO
    {
        public long Number { get; set; }
        public int CVV { get; set; }
    }
}
