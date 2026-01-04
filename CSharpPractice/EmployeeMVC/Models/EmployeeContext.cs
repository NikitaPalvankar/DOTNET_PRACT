using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmployeeMVC.Models
{
    public class EmployeeContext : DbContext    
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        //DbContext → database
        //DbSet<Employee> → table
        public DbSet<Employee> Employees { get; set; } 


    }
}
