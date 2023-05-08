using AutoMapper;
using BankManagement.BLL.DTOs.OrderDTOs;
using BankManagement.BLL.Services.Abstract;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;

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

        public IEnumerable<OrderToListDto> GetAll()
        {
            return _mapper.Map<IEnumerable<OrderToListDto>>(_orderRepository.GetAll());
        }

        public OrderByIdDto GetById(int id)
        {
            Order entity = _orderRepository.GetById(id);
            OrderByIdDto dto = _mapper.Map<OrderByIdDto>(entity);
            return dto;
        }

        public void Patch(int id,PatchOrderDto dto)
        {
            Order entity = _orderRepository.GetById(id);
            entity.StatusId = dto.StatusId;
            _orderRepository.Patch(entity);
        }
    }
}
