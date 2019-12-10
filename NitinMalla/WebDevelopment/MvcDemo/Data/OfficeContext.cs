using Microsoft.EntityFrameworkCore;
using MvcDemo.Models;

namespace  MvcDemo.Data
{
    public class OfficeContext :DbContext
    {        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
       //=> optionsBuilder.UseOracle(@"User Id=hr;Password=hr;Data Source=orcl;");
        => optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=OfficeDb;Trusted_Connection=True;");
      //  Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
    
    public DbSet<Employee> Employees {get; set;}
    }
}