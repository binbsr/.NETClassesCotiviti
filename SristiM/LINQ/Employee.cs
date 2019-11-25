using System;
using System.Collections.Generic;

public class Employee{
    public int ID{get;set;}
    public string Name{get;set;}
    public string Tier{get;set;}

    public string Department{get;set;}
}


public class EmployeeCollection{
    public static List<Employee> ExtractEmployeeInfo()
    {
        List<Employee> emp=new List<Employee>();
        emp.Add(new Employee{ID=1, Name="Employee1", Tier="Tier1", Department="RnD1"});
        emp.Add(new Employee{ID=2, Name="Employee2", Tier="Tier3",Department="RnD2"});
        emp.Add(new Employee{ID=3, Name="Employee3", Tier="Tier3",Department="RnD3"});
        return emp;
    }
}