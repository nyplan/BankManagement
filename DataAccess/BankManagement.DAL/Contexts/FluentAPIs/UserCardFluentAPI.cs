using BankManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts.FluentAPIs
{
    public static class UserCardFluentAPI
    {
        public static void UserCard(this ModelBuilder builder)
        {
            builder.Entity<UserCard>().HasIndex(c => new { c.Number, c.CVV, c.Pincode }).IsUnique();
        }
    }
}
