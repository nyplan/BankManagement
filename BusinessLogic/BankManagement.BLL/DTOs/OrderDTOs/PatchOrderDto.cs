namespace BankManagement.BLL.DTOs.OrderDTOs
{
    public record PatchOrderDto
    {
        public int OrderId { get; set; }
        public int StatusId { get; set; }
    }
}
