using BankManagement.BLL.DTOs.CardTypeDTOs;
using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.Services.Abstract
{
    public interface ICardService
    {
        CardTypeByBankIdDto GetByBankId(int id);
        CardTypeByIdDto GetById(int id);

    }
}
