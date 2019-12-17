using Microsoft.EntityFrameworkCore;
using MvcDemo1.Data;


namespace MvcDemo1.Data
{
    public class OfficeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OfficeDbVS;Trusted_Connection=True;");
        public DbSet<Employee> Employees { get; set; }
    }

}