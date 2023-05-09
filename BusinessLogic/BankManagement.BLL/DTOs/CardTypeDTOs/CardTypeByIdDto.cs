namespace BankManagement.BLL.DTOs.CardTypeDTOs
{
    public record CardTypeByIdDto
    {
        public string Name { get; set; }
        public double Comission { get; set; }
        public double CashBack { get; set; }
        public double MaxCapacity { get; set; }
        public int ExpireYear { get; set; }
        public string Bank { get; set; }
    }
}
