using Microsoft.EntityFrameworkCore;
using MVCDemo.Models;

namespace MVCDemo.Data {
    public class OfficeContext : DbContext {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer ("server=.;database=OfficeDbTest;trusted_connection=true;");
            //optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=OfficeDb;Trusted_Connection=True;MultipleActiveResultSets = True;");
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}