using BankManagement.DAL.Contexts;
using BankManagement.DAL.Contexts.Abstract;
using BankManagement.DAL.Contexts.Concrete;
using BankManagement.DAL.Repositories.Abstract;
using BankManagement.DAL.Repositories.Concrete;
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

            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            
        }
    }
}
