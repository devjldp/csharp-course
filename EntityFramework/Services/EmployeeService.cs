using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Data;  

namespace EntityFramework.Services
{
    public class EmployeeService
    {
        private readonly EmployeeContext _context;

        // Constructor that receives the EmployeeContext
        public EmployeeService(EmployeeContext context)
        {
            _context = context; // Asign the context to the private field.
        }

        // Create a new employee
        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges(); // Synchronous save
        }

        // Get all employees
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList(); // Synchronous query
        }

        // Get an employee by id
        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id); // Synchronous query
        }

        // Update an employee
        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges(); // Synchronous save
        }

        // Delete an employee
        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges(); // Synchronous save
            }
        }
    }
}
