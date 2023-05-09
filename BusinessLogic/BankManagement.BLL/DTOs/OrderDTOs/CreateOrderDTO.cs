namespace BankManagement.BLL.DTOs.OrderDTOs
{
	public record CreateOrderDTO
	{
		public int UserId { get; set; }
		public int CardTypeId { get; set; }
		public int Pincode { get; set; }
	}
}
