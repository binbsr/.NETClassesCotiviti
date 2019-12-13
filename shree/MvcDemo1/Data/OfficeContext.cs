using System;
using Microsoft.EntityFrameworkCore;
using MvcDemo.Models;
 
namespace  MvcDemo.Data
{
    public class OfficeContext :DbContext
    {        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EmpDbTable;Trusted_Connection=True;");

        internal object Departments()
        {
            throw new NotImplementedException();
        }

        //  Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

        public DbSet<Employee> Employees {get; set;}

        public DbSet<Department> Department {get;set;}
    }
}