using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.DTOs.CardTypeDTOs
{
    public record CardTypeToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Comission { get; set; }
        public double CashBack { get; set; }
        public double MaxCapacity { get; set; }
        public int BankId { get; set; }
    }
}
