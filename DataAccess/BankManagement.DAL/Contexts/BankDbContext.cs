using BankManagement.DAL.Contexts.DataSeed;
using BankManagement.DAL.Contexts.FluentAPIs;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;

namespace BankManagement.DAL.Contexts
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<CardType> CardTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            BankDataSeed.Seed(modelBuilder);  //data seed for bank table 
            CardTypeSeed.Seed(modelBuilder); //Data seed for CardType

            CardTypeFluentAPI.Fluent(modelBuilder); //FLuentAPI for CardType



		

		}


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.DeletedAt = DateTime.Now;
                }
                else
                {
                    _ = entry.State switch
                    {
                        EntityState.Added => entry.Entity.CreatedAt = DateTime.Now,
                        EntityState.Modified => entry.Entity.ModifiedAt = DateTime.Now,
                        _ => DateTime.Now
                    };
                }
            }
            return base.SaveChanges();
        }

        
    }

    
}
