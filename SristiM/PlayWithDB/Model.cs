using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

//dotnet core CLI for commands
public class CompanyContext : DbContext {//represents database 
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Department> Department { get; set; }
    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer ("server=.;database=Company;trusted_connection=true;");
    }

    // protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    // => optionsBuilder.UseSqlite(@"Data Source=Company.db;"); //using sqlite as database provider
    //using expression body member as the method is of one line only

    //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //  => optionsBuilder.UseSqlServer(@"Server=.;Database=Company;Trusted_Connection=True;MultipleActiveResultSets=true;"); 

}

//Employee and Department below are DTO objects-Data Transformation Objects
public class Employee {
    public int ID { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public double Salary { get; set; }
    public DateTime DOB { get; set; }
    public int DepartmentId { get; set; }
    //the convention is DepartmentID is the foreign key of Department table, auto identitfied(if tablenameid then its foreign key of tablename)
    public Department Department { get; set; }
}

public class Department {
    public int ID { get; set; }
    public string Name { get; set; }
    public string HOD { get; set; }
    public string Location { get; set; }
    public List<Employee> Employees { get; set; }

}

// using System;
// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;

// public class CompanyContext : DbContext 
// {
//     public DbSet<Employee> Employees{get; set;}
//     public DbSet<Department> Departments {get; set;}
//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//      => optionsBuilder.UseSqlite("Data Source = Company.db");   
// }

// public class Employee
// {
//     public int ID {get; set;}
//     public string Designation{get; set;}
//     public string Name{get; set;}
//     public decimal Salary{get; set;}
//     public DateTime DOB{get; set;}
//     public int DepartmentId{get; set;}

//     public Department Department{get; set;}
// }

// public class Department
// {
//     public int ID {get; set;}
//     public string Name{get; set;}

//     public string Location{get; set;}

//     public List<Employee> Employees{get; set;}
// }