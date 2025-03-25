using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EntityFramework.Data;
using System.IO;


namespace EntityFramework.Data
{
    public static class DbConfig
    {
        public static void ConfigureDatabase(IServiceCollection services)
        {
            // Load configuration from appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Retrieve the configuration string  
            var configString = config.GetConnectionString("DefaultConnection"); 

            // Register the DbContext in the dependencies container.  
            services.AddDbContext<EmployeeContext>(options => 
                options.UseNpgsql(configString)); // Use Npgsql to connect to PostgreSQL database
        }
    }
}