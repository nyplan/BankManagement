using AutoMapper;
using BankManagement.BLL.DTOs.OrderDTOs;
using BankManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.Mappers
{
	public class OrderMapper :Profile
	{
        public OrderMapper()
        {
            CreateMap<CreateOrderDTO, Order>();
        }
    }
}
