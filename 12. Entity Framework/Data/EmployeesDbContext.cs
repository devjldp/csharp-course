using Microsoft.EntityFrameworkCore; // For DbContext and other EF Core functionality
using Employees.Models;


namespace Employees.DataAnnotations
{
    public class EmployeesDbContext : DbContext
    {
        public DbSet<Employee> Employees{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\CFServer; Initial Catalog = Employees_testEF; Integrated Security = True");
        }
    }
}