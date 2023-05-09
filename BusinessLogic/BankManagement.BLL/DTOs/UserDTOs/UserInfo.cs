
namespace BankManagement.BLL.DTOs.UserDTOs
{
    public record UserInfo
    {
        public int Id { get; set; }
        public string Pin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
