using BankManagement.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BankManagement.DAL
{
    public static class ServiceRegistration
    {
        public static void AddDatabaseContext(this IServiceCollection services)
        {
            services.AddDbContext<BankDbContext>(options =>
            {
                options.UseSqlServer(DbConfiguration.ConnectionString);
            });

            
        }
    }
}
