public abstract class BaseEmployee  //Concrete base class
{
public int Id{get; set;}

public string FirstName {get;set;}

public string LastName {get;set;}

public string Address {get;set;}


public string GetFullName()=>$"{FirstName}{LastName}";
public virtual double CalculateMonthlySalary()=>0.0;


public abstract double CalculateTax();
// public virtual double calculatemonthlysalary --> allows child class to inherit

}


public sealed  class FullTimeEmployee :BaseEmployee
{
public double Monthlysalary{get;set;}
public  new string GetFullName()=>$"{base.GetFullName()} - Fulltime"; // user new for method hiding
public override double CalculateMonthlySalary()
{
    return Monthlysalary;
}

public override double CalculateTax() =>  2334;

}


public class  Contractor :BaseEmployee
{
 public double HourlyWage{get;set;}
 public new  string GetFullName()=>$"{base.GetFullName()} - Contractor";

 public override double CalculateMonthlySalary()
{
    return HourlyWage*160;
}

public override double CalculateTax() =>  2334;
}