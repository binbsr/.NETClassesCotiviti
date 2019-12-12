
using Microsoft.EntityFrameworkCore;
using MvcDemo.Models;
namespace MvcDemo.Data
{
    public class OfficeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Office;Trusted_Connection=True;");
        }
        public DbSet<Employee> Employees {get;set;}
        public DbSet<Department> Departments {get;set;}
    }
}