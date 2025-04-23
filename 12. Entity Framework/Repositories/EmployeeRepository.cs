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

    }
}