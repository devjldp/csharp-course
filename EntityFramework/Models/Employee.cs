using System.ComponentModel.DataAnnotations.Schema;
namespace EntityFramework.Models
{
    public class Employee
    {
        public int Id { get; set;}
        // Mapping Name property to full_name column
        [Column("Full_name")]
        public string Name { get; set;} //  Although my column is full_name, I can use Name as the property
        public int Age{ get; set;}
        public string City{ get; set;}
        public string Email{ get; set;}
        public string Role{ get; set;}
        
    }
}