using BankManagement.BLL.DTOs.CardTypeDTOs;

namespace BankManagement.BLL.DTOs.BankDtos
{
    public record BankByIdDto
    {
        public string Name { get; set; }
        public ICollection<CardTypeToListDto> CardType { get; set; }
    }
}
