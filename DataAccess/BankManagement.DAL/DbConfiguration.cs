using Microsoft.Extensions.Configuration;

namespace BankManagement.DAL
{
    public static class DbConfiguration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),
                    "../../Presentation/BankManagement.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("SQLServer");
            }
        }
    }
}
