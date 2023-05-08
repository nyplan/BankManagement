using BankManagement.BLL.DTOs.OrderDTOs;
using BankManagement.BLL.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankManagement.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly IOrderService _orderService;
        public OrderController(IOrderService service)
        {
            _orderService = service;
        }

        [HttpPost]
		public IActionResult Post(CreateOrderDTO dto) 
		{
			_orderService.Add(dto);

			return Ok();
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_orderService.GetAll());
		}

        [HttpGet("{id}")]
        public IActionResult GetByIdDto([FromRoute] int id)
        {
            return Ok(_orderService.GetById(id));
        }
        [HttpPatch("{id}")]
        public IActionResult PatchStatus([FromRoute] int id, int statusId)
        {
            _orderService.PatchStatus(id,statusId);
            return Ok();
        }
    }
}
