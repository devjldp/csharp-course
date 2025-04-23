using System.Collections.Generic;
using System.Linq;
using Employees.Models;
using Employees.DataAnnotations;

namespace Employees.Repositories
{
    public class EmployeeRepository : IRepository
    {
         private readonly EmployeesDbContext _context;

        public EmployeeRepository(EmployeesDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

    }
}