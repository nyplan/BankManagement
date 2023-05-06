using BankManagement.DAL.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions options) : base(options)
        {
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
