using System.ComponentModel.DataAnnotations;

namespace EmployeeMVC.Models
{
    public class Employee
    {
        //properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        public string Address { get; set; } 

    }
}
