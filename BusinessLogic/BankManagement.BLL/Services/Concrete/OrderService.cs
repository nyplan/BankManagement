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
        private readonly IUserCardRepository _userCardRepository;
		private readonly IMapper _mapper;
        public OrderService(IOrderRepository repository, IMapper mapper, IUserCardRepository userCardRepository)
        {
            _orderRepository = repository;
            _mapper = mapper;
            _userCardRepository = userCardRepository;
        }
        public void Add(CreateOrderDTO dto)
		{
			Order order = _mapper.Map<Order>(dto);
            _orderRepository.Add(order);
		}

        public IEnumerable<OrderToListDto> GetByUserId(int id)
        {
            return _mapper.Map<IEnumerable<OrderToListDto>>(_orderRepository.GetByUserId(id));
        }

        public OrderDTO GetById(int id)
        {
            Order entity = _orderRepository.GetById(id);
            if (entity.StatusId == 2)
            {
                UserCard data = _userCardRepository.GetByOrderId(id);
                AcceptedOrder order = _mapper.Map<AcceptedOrder>(entity);
                order.Number = data.Number;
                order.CVV = data.CVV;
                return order;
            }
            WaitRejectOrder dto = _mapper.Map<WaitRejectOrder>(entity);
            return dto;
        }

        public void PatchStatus(int id, int statusId)
        {
            Order entity = _orderRepository.GetById(id);
            entity.StatusId = statusId;
            if (statusId == 2)
            {
                UserCard uCard = new UserCard();
                Random random = new Random();
                bool check = true;
                while (check)
                {
                    uCard.Number = random.NextInt64(1111111111111111, 9999999999999999);
                    check = _userCardRepository.Any(card => card.Number == uCard.Number);
                }
                uCard.CVV = random.Next(100, 999);
                uCard.Pincode = entity.Pincode;
                uCard.OwnerName = entity.User.Username;
                uCard.UserId = entity.UserId;
                uCard.CardId = entity.CardTypeId;
                uCard.OrderId = entity.Id;
                _userCardRepository.Add(uCard);
            }
            _orderRepository.Patch(entity);
        }
    }
}
