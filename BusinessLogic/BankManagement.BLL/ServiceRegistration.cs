using BankManagement.BLL.Mappers;
using BankManagement.BLL.Services.Abstract;
using BankManagement.BLL.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace BankManagement.BLL
{
    public static class ServiceRegistration
    {
        public static void AddBLLServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapperProfile),typeof(CardTypeMapper));
            services.AddScoped<ICardService, CardService>();
        }
    }
}
