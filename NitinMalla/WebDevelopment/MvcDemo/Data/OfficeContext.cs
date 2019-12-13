using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MvcDemo.Models;
 
namespace MvcDemo.Data
{
    public class OfficeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {       
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestDb;Trusted_Connection=True;");
             //=> optionsBuilder.UseOracle(@"User Id=hr;Password=hr;Data Source=orcl;");
              //=> optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=OfficeDb;Trusted_Connection=True;");
 
        }
        public DbSet<Employee> Employees {get;set;}

        public DbSet<Department> Departments {get;set;}
 
    }
 
}