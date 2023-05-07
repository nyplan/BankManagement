using AutoMapper;
using BankManagement.BLL.DTOs.OrderDTOs;
using BankManagement.BLL.Services.Abstract;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.Services.Concrete
{
	public class OrderService : IOrderService
	{
		private readonly IOrderRepository _orderRepository;
		private readonly IMapper _mapper;
        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _orderRepository = repository;
			_mapper = mapper;
        }
        public void Add(CreateOrderDTO dto)
		{
			Order order = _mapper.Map<Order>(dto);
            _orderRepository.Add(order);
		}
	}
}
