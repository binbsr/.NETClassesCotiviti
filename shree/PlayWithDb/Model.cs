using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayWithDb
{
    public class CompanyContext : DbContext
    {
        public DbSet<Employee> EmployeeTable { get; set; }
        public DbSet<Department> DepartmentTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite("Data Source = CompanyDb.db");          // CompanyDb.db is database file name

    }
    public class Employee       // this class represent the database table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public Double Salary { get; set; }
        public DateTime Dob { get; set; }
        public int DeptId { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
