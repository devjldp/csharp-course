using System.Collections.Generic;
using System.Linq;
using Employees.Models;
using Employees.DataAnnotations;
using Employees.Repositories;

namespace Employees.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeesDbContext _context; // Private field to hold the reference to the database context.

        public EmployeeRepository(EmployeesDbContext context) // Constructor that receives the database context via dependency injection.
        {
            _context = context;
        }

        // Method to add a new employee to the database
        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee); // Adds the new employee to the Employees table (tracked by EF Core)
            _context.SaveChanges(); // Saves the changes to the database (executes the SQL INSERT)
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public void DeleteEmployee(int employeeId)
        {
            // first I need to find the element that I want to remove. To do tha I use LINQ
            Employee employee = _context.Employees.First(employee => employee.Id == employeeId);
          
            // Remove
            _context.Remove(employee);
            // save changes to database
            _context.SaveChanges();

            Console.WriteLine("Employee Removed succesfully!");
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _context.Employees.Find(employeeId);
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.SaveChanges();
        }

    }
}