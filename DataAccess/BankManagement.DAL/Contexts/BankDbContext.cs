﻿using BankManagement.DAL.Contexts.DataSeed;
using BankManagement.DAL.Contexts.FluentAPIs;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OrderStatus> OrderStatus{ get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<UserCard> UserCards { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            BankDataSeed.Seed(modelBuilder);  //data seed for bank table 
            CardTypeSeed.Seed(modelBuilder); //Data seed for CardType
            OrderStatusSeed.Seed(modelBuilder); //Data seed for Statuses for Order. Only 3 tpye of status. 

            CardTypeFluentAPI.Fluent(modelBuilder); //FLuentAPI for CardType
            UserFluentAPI.UserPin(modelBuilder);  // Unique User PIN 
            UserCardFluentAPI.UserCard(modelBuilder); // Unique Card Number,CVV,Pincode

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

            foreach (var entry in ChangeTracker.Entries<Order>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.StatusId = 1;
                }
            }

            return base.SaveChanges();
        }

        
    }

    
}
