namespace Marathon.Server.Infrastructure.Extensions
{
    using Humanizer.Configuration;
    using Marathon.Server.Azure;
    using Microsoft.Extensions.Configuration;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public static class ConfigurationExtensions
    {

        public static string GetDefaultConnectionString(this IConfiguration configuration)
        {
            KeyVaultManager keyVaultManager = new KeyVaultManager();


            var db = keyVaultManager.GetSecret("db");





            return configuration.GetConnectionString("DefaultConnection");
        }

        public static async Task<string> GetDefaultConnectionStringAsync(this IConfiguration configuration)
        {
            KeyVaultManager keyVaultManager = new KeyVaultManager();

            var db = await keyVaultManager.GetSecretAsync("db");

            return db;
        }

    }
}
