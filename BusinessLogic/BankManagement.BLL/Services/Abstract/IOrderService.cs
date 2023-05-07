using BankManagement.BLL.DTOs.OrderDTOs;

namespace BankManagement.BLL.Services.Abstract
{
	public interface IOrderService
	{
		public void Add(CreateOrderDTO dto);
		IEnumerable<OrderToListDto> GetAll();
	}
}
