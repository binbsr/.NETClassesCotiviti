using System;

public  abstract class CotivitiEmployee{

    public string employeeId{get;set;}
    public string name{get;set;}
    
    public double baseSalary{get;set;}

    public string  TimeZome {get;set;}      
    

    

    public double ExperineceYears{get;set;}

    public int MinimumWorkingHours{get;set;}

    public  double GetSalary()
    {
        return baseSalary*ExperineceYears;
    }

    public virtual double getWorkFromHomeHours()
    {
       return (MinimumWorkingHours);
    }
    
}

public class OffshoreEmployee:CotivitiEmployee,Iproject,IFunding
{

        public string location;
        public new string  TimeZome {get;set;}   

    public void GetProjectDetails()
    {
        Console.WriteLine("get project");
    }

    public void GetteambuildingFund()
    {
        Console.WriteLine("Employee fund");
    }

    public  new double GetSalary() => baseSalary * ExperineceYears ;

    public override double getWorkFromHomeHours()
    {

        return (base.getWorkFromHomeHours()*10)/100;
        
    }


}

 public sealed class InternEmployee:OffshoreEmployee
{
    public double providentFund;

    public new double GetSalary()
    {
        return baseSalary*100;
    }
    public override double getWorkFromHomeHours()
    {
        return base.getWorkFromHomeHours()+5;
        
    }
}


public class Department
{
    public string departmentId;
    public string regionalHead;

    public string GetChairPerson()
    {
        return regionalHead;
    }
   
}

public class EngineeringDepartment :Department ,Iproject,IFunding
{
    public string departmentName;

    public string departmentalHead;

    public new string GetChairPerson()
    {
        return departmentalHead;
    }
     public void GetProjectDetails() => Console.WriteLine("project details");

    public void GetteambuildingFund()
    {
        Console.WriteLine("Department fund");
    }
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
   