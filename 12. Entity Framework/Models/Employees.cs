using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Models
{
    [Table("employee")] // This indicates that the model is related to the "employee" table
    public class Employee
    {
        [Key] // Marks this property as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Indicates that it's auto-generated by the database
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("role")]
        public string Role { get; set; }
    }
}
