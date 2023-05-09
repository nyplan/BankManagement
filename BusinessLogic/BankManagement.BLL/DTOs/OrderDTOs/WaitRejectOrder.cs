namespace BankManagement.BLL.DTOs.OrderDTOs
{
    public record WaitRejectOrder : OrderDTO
    {
        public int Id { get; set; }
        public string Ownername { get; set; }
        public string Card { get; set; }
        public int Pincode { get; set; }
        public string Status { get; set; }
    }
}
