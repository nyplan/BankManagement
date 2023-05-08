namespace BankManagement.BLL.DTOs.CardTypeDTOs
{
    public record CardTypeToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Comission { get; set; }
        public double CashBack { get; set; }
        public int ExpireYear { get; set; }
        public double MaxCapacity { get; set; }
    }
}
