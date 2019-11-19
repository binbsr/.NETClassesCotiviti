using System;

public class Employee{

    public string employeeId;
    public string name;
}

public class OnshoreEmployee:Employee,Iproject,IFunding
{
    public string location;

    public void GetProjectDetails()
    {
        Console.WriteLine("get project");
    }

    public void GetteambuildingFund()
    {
        Console.WriteLine("Employee fund");
    }

    
}

public class Company
{
    public string officeName;
}

public class Department:Company,Iproject,IFunding
{
    public string departmentId;
    public void GetProjectDetails() => Console.WriteLine("project details");

    public void GetteambuildingFund()
    {
        Console.WriteLine("Department fund");
    }
}

public class Team:Department
{
    public string teamname;
}

public interface Iproject
{
   public void GetProjectDetails();
}

public class FeatureStory : Iproject
{
    public void GetProjectDetails()
    {
       Console.WriteLine("project detail");
    }
}

public interface IFunding
{
   public void GetteambuildingFund();
}
   