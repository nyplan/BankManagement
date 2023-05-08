using BankManagement.BLL.DTOs.OrderDTOs;

namespace BankManagement.BLL.Services.Abstract
{
	public interface IOrderService
	{
		public OrderByIdDto GetById(int id);
		public void Add(CreateOrderDTO dto);
		IEnumerable<OrderToListDto> GetAll();
		public void PatchStatus(int id, int statusId);
	}
}
