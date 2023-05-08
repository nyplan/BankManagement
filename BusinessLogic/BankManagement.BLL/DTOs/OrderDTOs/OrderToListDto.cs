
namespace BankManagement.BLL.DTOs.OrderDTOs
{
    public record OrderToListDto
    {
        public string Username { get; set; }
        public string CardType { get; set; }
        public string Status { get; set; }
    }
}
