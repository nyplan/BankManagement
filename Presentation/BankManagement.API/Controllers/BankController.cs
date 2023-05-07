using BankManagement.BLL.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService _bankService;
        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }
         
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_bankService.Get(id));
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_bankService.Get());
        }
    }
}
