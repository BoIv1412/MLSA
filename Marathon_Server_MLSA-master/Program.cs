namespace Marathon.Server
{
    using Marathon.Server.Azure;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Identity.Client.Extensibility;
    using System.Diagnostics;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            KeyVaultManager keyVaultManager = new KeyVaultManager();

            //Debug.WriteLine(keyVaultManager.GetSecret("db"));

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
