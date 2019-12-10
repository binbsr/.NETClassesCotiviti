using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MvcDemo.Models;

namespace MvcDemo.Data
{
    public class OfficeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {       
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OfficeDb;Trusted_Connection=True;");

        }
        public DbSet<Employee> Employees {get;set;}


    }

}