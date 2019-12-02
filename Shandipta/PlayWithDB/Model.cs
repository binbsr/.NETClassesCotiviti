using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
public class CompanyContext : DbContext
{
    public DbSet<Employee> Employee { get; set; } //create a table by a name Employee
    public DbSet<Department> Department { get; set; } //create a table by a name
    protected override void OnConfiguring(DbContextOptionsBuilder operationBUilder)
    => operationBUilder.UseSqlite("Data Source = Company.db"); //Db connection string using sqlite


}


public class Employee
{

    public int Id { get; set; }
    public string Degisnation { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public DateTime DOB { get; set; }
    public int DepartmentId { get; set; } //Convention
    public Department Department { get; set; }
    //DDO

}

public class Department
{


    public int ID { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public List<Employee> Employee { get; set; }
}

//convention over configuration