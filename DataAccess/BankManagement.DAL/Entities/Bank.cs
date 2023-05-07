using BankManagement.DAL.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAL.Entities
{
    public class Bank:BaseEntity
    {
        public string Name { get; set; }
    }
}
