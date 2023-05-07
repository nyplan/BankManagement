using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAL.Repositories.Abstract
{
    internal interface IBankRepository
    {
        List<Bank> Get();
        Bank Get(int id);
    }
}
