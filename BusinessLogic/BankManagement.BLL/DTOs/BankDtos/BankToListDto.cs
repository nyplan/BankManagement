using BankManagement.BLL.DTOs.CardTypeDTOs;
using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.DTOs.BankDtos
{
    public record BankToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CardTypeToListDto> CardType { get; set; }
    }
}
