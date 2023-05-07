using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.DTOs.OrderDTOs
{
    public record OrderByIdDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CardTypeId { get; set; }
        public int StatusId { get; set; }
    }
}
