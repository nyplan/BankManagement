using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BankManagement.BLL
{
    public static class ServiceRegistration
    {
        public static void AddBLLServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
