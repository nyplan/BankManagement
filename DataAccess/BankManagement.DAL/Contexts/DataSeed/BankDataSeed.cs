using BankManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts.DataSeed
{
    //this class use for data seed for bank table 
    //every data seed must be follow this rule 
    public static class BankDataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Bank>().HasData(
             new Bank()
            {
                 Id = 1,
                 Name= "Kapital Bank ",
                 CreatedAt = DateTime.Now //this code will add added time to CreatedAt column
            },
             new Bank()
             {
                 Id= 2,
                 Name= "ABB",
                 CreatedAt = DateTime.Now
             },
             new Bank()
             {
                 Id= 3,
                 Name="Merkezi Bank",
                 CreatedAt= DateTime.Now
             }
             );
        }
    }
}
