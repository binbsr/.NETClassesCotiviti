using Microsoft.EntityFrameworkCore;
using MvcDemo.Models;


namespace MvcDemo.Data
{
    public class OfficeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OfficeDbNew;Trusted_Connection=True;");
         public DbSet<Employees> Employees{get; set;}
    }
   
}