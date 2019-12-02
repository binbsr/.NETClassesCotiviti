using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



public class CompanyContext:DbContext
{
  public DbSet<Employee> Employee{get;set;}
  public DbSet<Department> Department{get;set;}

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>optionsBuilder.UseSqlite("Data Source=Company.db");
}

//DTO-Data transfer object
public class Employee
{
    public int ID{get;set;}

    public string name{get;set;}

    public string Designation{get;set;}
    public decimal salary{get;set;}
    public DateTime DOB{get;set;}

    public int DepartmentId{get;set;}

    public Department Department{get;set;}
    
}
public class Department
{
    public int ID{get;set;}

    public string name{get;set;}

    public string Location {get;set;}
   
    public List<Employee> Employees{get;set;}
}