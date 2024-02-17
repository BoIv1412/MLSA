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
            // Initialize KeyVaultManager with IConfiguration instance
            KeyVaultManager keyVaultManager = new KeyVaultManager();

            // Retrieve secret from Azure Key Vault
            var db = keyVaultManager.GetSecret("db");

            // Return the connection string
            return configuration.GetConnectionString("DefaultConnection");
        }

        public static async Task<string> GetDefaultConnectionStringAsync(this IConfiguration configuration)
        {
            // Initialize KeyVaultManager with IConfiguration instance
            KeyVaultManager keyVaultManager = new KeyVaultManager();

            // Retrieve secret from Azure Key Vault asynchronously
            var db = await keyVaultManager.GetSecretAsync("db");

            // Return the connection string
            return db;
        }
    }
}
