using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class CompanyContext : DbContext 
{
    public DbSet<Employee> Employees{get; set;}
    public DbSet<Department> Departments {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder.UseSqlite("Data Source = Company.db");   
}

public class Employee
{
    public int ID {get; set;}
    public string Designation{get; set;}
    public string Name{get; set;}
    public decimal Salary{get; set;}
    public DateTime DOB{get; set;}
    public int DepartmentId{get; set;}

    public Department Department{get; set;}
}

public class Department
{
    public int ID {get; set;}
    public string Name{get; set;}

    public string Location{get; set;}


    public List<Employee> Employees{get; set;}
}