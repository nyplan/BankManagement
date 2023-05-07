using BankManagement.BLL.Mappers;
using BankManagement.DAL.Entities;
using BankManagement.BLL.Services.Abstract;
using BankManagement.BLL.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace BankManagement.BLL
{
    public static class ServiceRegistration
    {
        public static void AddBLLServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BankmapperProfile),typeof(Bank), typeof(CardTypeMapper));
            services.AddScoped<ICardService, CardService>();
        }
    }
}
