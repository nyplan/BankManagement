using BankManagement.BLL.DTOs.UserDTOs;
using BankManagement.BLL.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BankManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Register(UserRegister user)
        {
            _service.Register(user);
            return Ok();
        }
        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            UserInfo user = null;
            try
            {
                 user = _service.Login(new UserLogin() { Username = username, Password = password });
            }
            catch (Exception)
            {
                return BadRequest("Username or password is incorrect");
            }
            return Ok(user);
        }
    }
}
