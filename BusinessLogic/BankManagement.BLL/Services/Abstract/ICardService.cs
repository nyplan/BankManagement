using BankManagement.BLL.DTOs.CardTypeDTOs;

namespace BankManagement.BLL.Services.Abstract
{
    public interface ICardService
    {
        IEnumerable<CardTypeByBankIdDto> GetByBankId(int id);
        CardTypeByIdDto GetById(int id);

    }
}
