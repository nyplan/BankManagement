using BankManagement.BLL.DTOs.OrderDTOs;

namespace BankManagement.BLL.Services.Abstract
{
	public interface IOrderService
	{
		public OrderDTO GetById(int id);
		public void Add(CreateOrderDTO dto);
		IEnumerable<OrderToListDto> GetByUserId(int id);
		public void PatchStatus(int id, int statusId);
	}
}
