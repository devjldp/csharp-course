using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// using Employees.Models;
// using Employees.Repositories;
// using Employees.DataAnnotations;
using Employees.Controller;


namespace Employees.ConsoleApp
{
    class Program
    {
        private static EmployeeController _employeeController;
        static string Menu()
        {
            Console.Clear();
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Add a new employee");
                Console.WriteLine("2. Show all employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee");
                Console.WriteLine("5. Delete Emnployee");
                Console.WriteLine("6. Exit");
                Console.Write("\nChoose an option: ");

                string option = Console.ReadLine();
                return option;
        }

        static void Main(string[] args)
        {                      
            _employeeController = new EmployeeController(); // create a new instance of the controller.

            // Menú to interact with the database.
            while (true)
            {
                string option = Menu();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("\nAdd a new emnployee:");
                        Console.Write("First name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("City: ");
                        string city = Console.ReadLine();
                        Console.Write("Role: ");
                        string role = Console.ReadLine();
                        _employeeController.AddEmployee(firstName, lastName, city, role);
                        break;
                    case "2":
                        _employeeController.DisplayAllEmployees();
                        break;
                    case "3":
                        Console.Write("Enter employee's ID you want to display: ");
                        int employeeId = int.Parse(Console.ReadLine());
                        _employeeController.DisplayEmployee(employeeId);
                        break;
                    case "4":
                        // UpdateEmployee();
                        Console.Write("Enter employee's ID you want to update: ");
                        employeeId = int.Parse(Console.ReadLine());
                        _employeeController.UpdateEmployee(employeeId);
                        Console.WriteLine("Method to implement");
                        break;
                    case "5":
                        Console.Write("Enter employee's ID you want to remove: ");
                        employeeId = int.Parse(Console.ReadLine());
                        _employeeController.DeleteEmployee(employeeId);
                        break;
                    case "6":
                        Console.WriteLine("Exit...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        
        }

    
    }
}