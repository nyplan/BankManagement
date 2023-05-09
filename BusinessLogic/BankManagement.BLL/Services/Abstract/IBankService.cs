using BankManagement.BLL.DTOs.BankDtos;

namespace BankManagement.BLL.Services.Abstract
{
    public interface IBankService
    {
        List<BankToListDto> Get();
        BankByIdDto Get(int id);

    }
}
