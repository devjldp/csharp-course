namespace EntityFramework.Data{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set;}

        // constructor:
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options){ }
    }
}