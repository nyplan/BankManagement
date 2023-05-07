using BankManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts.FluentAPIs
{
    public static class UserFluentAPI
    {
        public static void UserPin(this ModelBuilder builder)
        {
            builder.Entity<User>().HasIndex(c => c.Pin).IsUnique();
        }
    }
}
