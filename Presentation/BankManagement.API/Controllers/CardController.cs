using BankManagement.BLL.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;
        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }
        // GET api/<CardController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_cardService.GetById(id));
        }

        [HttpGet("BankId/{id}")]
        public IActionResult GetByBankId(int id)
        {
            return Ok(_cardService.GetByBankId(id));
        }

    }
}
