using System;
using System.IO; // working with File, Directory, FileStream class. Neccessary for Directory class
using Microsoft.Extensions.Configuration; 
using Npgsql;

namespace DbConnect.Data
{
    public class DbConnection
    {
        private string _connectionString;
        
        public DbConnection()    // Consturctor
        {
            // Load configuration from appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
                
            // retrieve the connection string
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        // Method to get the connection object
        public NpgsqlConnection GetConnection()
        {
            // Returns a connection to the database using the connection string
            return new NpgsqlConnection(_connectionString);
        }
    }
}


