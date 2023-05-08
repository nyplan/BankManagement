using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.DTOs.OrderDTOs
{
    public record PatchOrderDto
    {
        //public int UserId { get; set; }
        //public int CardTypeId { get; set; }
        public int StatusId { get; set; }
    }
}
