using AutoMapper;
using BankManagement.BLL.DTOs.OrderDTOs;
using BankManagement.DAL.Entities;

namespace BankManagement.BLL.Mappers
{
    public class OrderMapper :Profile
	{
        public OrderMapper()
        {
            CreateMap<CreateOrderDTO, Order>();
            CreateMap<PatchOrderDto, Order>();
            CreateMap<Order, OrderToListDto>()
                .ForMember(dest => dest.Username, src => src.MapFrom(c => c.User.Username))
                .ForMember(dest => dest.CardType, src => src.MapFrom(c => c.CardType.Name))
                .ForMember(dest => dest.Status, src => src.MapFrom(c => c.OrderStatus.StatusValue));

            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.Ownername, src => src.MapFrom(c => c.User.Username))
                .ForMember(dest => dest.Status, src => src.MapFrom(c => c.OrderStatus.StatusValue))
                .ForMember(dest => dest.Card, src => src.MapFrom(c => c.CardType.Name));
        }
    }
}
