using BankManagement.BLL.DTOs.OrderDTOs;

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

        [HttpGet("user/{userId}")]
		public IActionResult Get(int userId)
		{
			return Ok(_orderService.GetByUserId(userId));
		}

        [HttpGet("{id}")]
        public IActionResult GetByIdDto([FromRoute] int id)
        {
            return Ok(_orderService.GetById(id));
        }
        [HttpPatch("{id}/status")]
        public IActionResult PatchStatus([FromRoute] int id, int statusId)
        {
            _orderService.PatchStatus(id,statusId);
            return Ok();
        }
    }
}
