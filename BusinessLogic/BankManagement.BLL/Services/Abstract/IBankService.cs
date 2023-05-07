using BankManagement.BLL.DTOs.BankDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.Services.Abstract
{
    internal interface IBankService
    {
        List<BankToListDto> Get();
        BankByIdDto Get(int id);

    }
}
