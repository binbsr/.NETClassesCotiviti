using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
//dotnet tool install --global-- avvialable to al users
//nuget package

public class CompanyContext : DbContext
{
    public DbSet<Employee> Employee { get; set; } //property
    public DbSet<Department> Department { get; set; } //property
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlite("Data source= Company.db");//connection string for Database

}
public class Employee
{
    //data transfer object

    public int Id { get; set; }
    public string Designation { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public DateTime DOB { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
}
//code first approach