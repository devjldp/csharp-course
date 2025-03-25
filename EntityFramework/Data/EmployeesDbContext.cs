using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;


namespace EntityFramework.Data{
    public class EmployeeContext : DbContext
    {
        // This property maps to the 'Employees' table in the database
        public DbSet<Employee> Employees { get; set;}

        // constructor:
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options){ }

        // Override OnModelCreating to configure the entity relationships if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Here you can define any additional configuration if required
            base.OnModelCreating(modelBuilder);
        }
    }
}