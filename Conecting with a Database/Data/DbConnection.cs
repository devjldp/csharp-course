using System;
using System.IO; // working with File, Directory, FileStream class.
using Microsoft.Extensions.Configuration; 
using Npgsql;

namespace DbConnect.Data
{
    public class DbConnection
    {
        private string _connectionString;
        
        // Consturctor
        public DbConnection()
        {
            // Load configuration from appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

        // retrieve the string conexion
            _connectionString = config.GetConnectionString("DefaultConnection");
        }


        // Method to get the connection object
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}


