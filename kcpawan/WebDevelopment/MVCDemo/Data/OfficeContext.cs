using Microsoft.EntityFrameworkCore;
using MVCDemo.Models;

namespace MvcDemo.Data
        {
            //Console.WriteLine("Hello World!");

            public class OfficeContext: DbContext
            {
                
                protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
                {
                    optionBuilder.UseSqlServer(@"Server=PAWANKC\KCPAWAN;Database=OfficeDb;Trusted_Connection=True;");
                }

                public DbSet<Employee> Employees {get; set;}
               


            }
        }

