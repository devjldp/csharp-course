// Importing the data context and models from the EntityFramework.Data namespace
using EntityFramework.Data;
// Importing the services that handle business logic
using EntityFramework.Services;
// Importing the dependency injection library to register services
using Microsoft.Extensions.DependencyInjection;
// Importing the configuration library to read appsettings.json
using Microsoft.Extensions.Configuration;

using EntityFramework.Models;

namespace EntityFramework
{
    public class Program
    {
        static void Main()
        {
            /*
        // Configuring services (Dependency Injection)
        var serviceProvider = new ServiceCollection()
            .ConfigureDatabase() // This will call the ConfigureDatabase method from DbConfig, handling appsettings.json and DbContext registration
            .AddScoped<EmployeeService>() // Register EmployeeService to handle business logic
            .BuildServiceProvider(); // Build the service provider to resolve dependencies
*/

// Crear una nueva colección de servicios
            var serviceCollection = new ServiceCollection();

            // Configurar la base de datos
            serviceCollection.ConfigureDatabase(); // Aquí solo llamamos a ConfigureDatabase()

            // Registrar el servicio de EmployeeService
            serviceCollection.AddScoped<EmployeeService>();

            // Construir el proveedor de servicios
            var serviceProvider = serviceCollection.BuildServiceProvider();

        



        // Get the EmployeeService instance from the service provider
        var employeeService = serviceProvider.GetService<EmployeeService>();

        Console.WriteLine("Enter the employee's name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the city:");
        string city = Console.ReadLine();
        Console.WriteLine("Enter the email:");
        string email = Console.ReadLine();
        Console.WriteLine("Enter the role:");
        string role = Console.ReadLine();

        var newEmployee = new Employee { Name = name, Age = age, City = city, Email = email, Role = role };
        employeeService.AddEmployee(newEmployee);

        Console.WriteLine("Employee successfully added.");
        Console.ReadLine();
        }
    }
}