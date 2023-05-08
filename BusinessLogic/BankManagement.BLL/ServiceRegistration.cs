using BankManagement.BLL.Mappers;
using BankManagement.BLL.Services.Abstract;
using BankManagement.BLL.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BankManagement.BLL
{
    public static class ServiceRegistration
    {
        public static void AddBLLServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BankmapperProfile),typeof(UserMapper), typeof(CardTypeMapper), typeof(OrderMapper));
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IBankService, BankService>();
        }
    }
}
