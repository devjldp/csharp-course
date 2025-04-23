


namespace Employees.DataAnnotations
{
    public class EmployeesDbContext : DbContext
    {
        public DbSet<Employee> Employee{ get; set; }
    }
}