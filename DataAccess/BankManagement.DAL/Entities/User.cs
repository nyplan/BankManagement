using BankManagement.DAL.Entities.Common;

namespace BankManagement.DAL.Entities
{
    public class User : BaseEntity
    {
        public string Pin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
