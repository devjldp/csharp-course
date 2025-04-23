using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Employees.Models;
using Employees.Repositories;
using Employees.DataAnnotations;


namespace Employees.ConsoleApp
{
    class Program
    {
        private static EmployeeRepository _employeeRepository;

        static void Main(string[] args)
        {
            // Inicializar el DbContext
                        
            var context = new EmployeesDbContext(); // create a new instance of the context

            _employeeRepository = new EmployeeRepository(context); // Create a new instance of EmployeeRepository
            
            // Menú para interactuar con la base de datos
            while (true)
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

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        DisplayAllEmployees();
                        break;
                    case "3":
                        // GetEmployeeById();
                        Console.WriteLine("Method to implement");
                        break;
                    case "4":
                        // UpdateEmployee();
                        Console.WriteLine("Method to implement");
                        break;
                    case "5":
                        Console.WriteLine("Method to implement");
                        // DeleteEmployee();
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

        static void AddEmployee()
        {
            Console.WriteLine("\nAdd a new emnployee:");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("Role: ");
            string role = Console.ReadLine();

            var employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                City = city,
                Role = role
            };

            _employeeRepository.AddEmployee(employee);
            Console.WriteLine("\nEmpleado added succesfully!");
            Console.ReadLine();
        }

        static void DisplayAllEmployees()
        {
            Console.WriteLine("\nLista de empleados:");
            var employees = _employeeRepository.GetAllEmployees();
            
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id} | Name: {employee.FirstName} {employee.LastName} | City: {employee.City} | Role: {employee.Role}");
            }

            Console.ReadLine();
        }

        // static void GetEmployeeById()
        // {
        //     Console.WriteLine("\nBuscar empleado por ID:");
        //     Console.Write("ID: ");
        //     int id = int.Parse(Console.ReadLine());

        //     var employee = _employeeRepository.GetEmployeeById(id);
        //     if (employee != null)
        //     {
        //         Console.WriteLine($"ID: {employee.Id}, Nombre: {employee.FirstName} {employee.LastName}, Ciudad: {employee.City}, Rol: {employee.Role}");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Empleado no encontrado.");
        //     }

        //     Console.ReadLine();
        // }

        // static void UpdateEmployee()
        // {
        //     Console.WriteLine("\nActualizar empleado:");
        //     Console.Write("ID: ");
        //     int id = int.Parse(Console.ReadLine());

        //     var employee = _employeeRepository.GetEmployeeById(id);
        //     if (employee != null)
        //     {
        //         Console.Write("Nuevo nombre (dejar vacío para no cambiar): ");
        //         string firstName = Console.ReadLine();
        //         Console.Write("Nuevo apellido (dejar vacío para no cambiar): ");
        //         string lastName = Console.ReadLine();
        //         Console.Write("Nueva ciudad (dejar vacío para no cambiar): ");
        //         string city = Console.ReadLine();
        //         Console.Write("Nuevo rol (dejar vacío para no cambiar): ");
        //         string role = Console.ReadLine();

        //         // Si el campo no está vacío, actualizamos el valor
        //         if (!string.IsNullOrEmpty(firstName)) employee.FirstName = firstName;
        //         if (!string.IsNullOrEmpty(lastName)) employee.LastName = lastName;
        //         if (!string.IsNullOrEmpty(city)) employee.City = city;
        //         if (!string.IsNullOrEmpty(role)) employee.Role = role;

        //         _employeeRepository.UpdateEmployee(employee);
        //         Console.WriteLine("\nEmpleado actualizado exitosamente!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Empleado no encontrado.");
        //     }

        //     Console.ReadLine();
        // }

        // static void DeleteEmployee()
        // {
        //     Console.WriteLine("\nEliminar empleado:");
        //     Console.Write("ID: ");
        //     int id = int.Parse(Console.ReadLine());

        //     _employeeRepository.DeleteEmployee(id);
        //     Console.WriteLine("Empleado eliminado exitosamente!");
        //     Console.ReadLine();
        // }
    }
}