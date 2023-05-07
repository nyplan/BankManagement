
namespace BankManagement.BLL.DTOs.OrderDTOs
{
    public record OrderToListDto
    {
        public int Username { get; set; }
        public int CardType { get; set; }
        public int Status { get; set; }
    }
}
