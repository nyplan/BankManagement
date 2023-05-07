using System.ComponentModel.DataAnnotations;

namespace BankManagement.BLL.DTOs.UserDTOs
{
    public record UserRegister
    {
        [Required]
        public int Pin { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
