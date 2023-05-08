using BankManagement.BLL.DTOs.OrderDTOs;
using BankManagement.DAL.Entities;

namespace BankManagement.BLL.Services.Abstract
{
	public interface IOrderService
	{
		public OrderByIdDto GetById(int id);
		public void Add(CreateOrderDTO dto);
		IEnumerable<OrderToListDto> GetAll();
		public void Patch(int id,PatchOrderDto dto);
	}
}
