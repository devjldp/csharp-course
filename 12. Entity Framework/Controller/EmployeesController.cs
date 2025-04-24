using System;
using System.Collections.Generic;
using System.Linq;                // Add LINQ

using Employees.DataAnnotations;   // Add the context
using Employees.Models;           // Add the model
using Employees.Repositories;     // Add the repository

namespace Employees.Controller
{
    public class EmployeeController
    {
        private static EmployeeRepository _employeeRepository;
        private static EmployeesDbContext _context;
        public EmployeeController()
        {
            _context = new EmployeesDbContext(); // create a new instance of the context
            _employeeRepository = new EmployeeRepository(_context);
        }

        // methods

        public void AddEmployee(string firstName, string lastName, string city, string role)
        {
            // Creating a new employee object
            Employee employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                City = city,
                Role = role
            };
            
            _employeeRepository.AddEmployee(employee); // Using .AddEmployee() method from repository
            Console.WriteLine("\nEmployee added succesfully!. Press enter to continue!.");
            Console.ReadLine();
        }

        public void DisplayAllEmployees()
        {
            Console.WriteLine("\nList of Employees:");
            var employees = _employeeRepository.GetAllEmployees();
            
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id} | Name: {employee.FirstName} {employee.LastName} | City: {employee.City} | Role: {employee.Role}");
            }
            Console.WriteLine("Press enter to continue!.");
            Console.ReadLine();
        }


        public void DeleteEmployee(int employeeId)
        {
            _employeeRepository.DeleteEmployee(employeeId);
            Console.WriteLine("Employee removed successfully!.");
            Console.WriteLine("Press enter to continue!.");
            Console.ReadLine();
        }

        public void DisplayEmployee(int employeeId)
        {
            Employee employee = _employeeRepository.GetEmployeeById(employeeId);
            Console.WriteLine($"ID: {employee.Id} | Name: {employee.FirstName} {employee.LastName}| City: {employee.City}| Role: {employee.Role}");
            Console.WriteLine("Press enter to continue!.");
            Console.ReadLine();
        }


        public void UpdateEmployee(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            DisplayEmployee(id);
            if (employee != null){
                Console.Write("Modify first name. Leave empty if you don't want to modify it. ");
                string firstName = Console.ReadLine();
                Console.Write("Modify last name. Leave empty if you don't want to modify it. ");
                string lastName = Console.ReadLine();
                Console.Write("Modify city. Leave empty if you don't want to modify it. ");
                string city = Console.ReadLine();
                Console.Write("Modify role. Leave empty if you don't want to modify it. ");
                string role = Console.ReadLine();
               
                if (!string.IsNullOrEmpty(firstName)) employee.FirstName = firstName;
                if (!string.IsNullOrEmpty(lastName)) employee.LastName = lastName;
                if (!string.IsNullOrEmpty(city)) employee.City = city;
                if (!string.IsNullOrEmpty(role)) employee.Role = role;
            }
            _employeeRepository.UpdateEmployee(employee);
        }
    }

}