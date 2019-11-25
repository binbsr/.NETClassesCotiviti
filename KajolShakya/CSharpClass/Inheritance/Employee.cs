namespace Inheritance{


public abstract class BaseEmployee
{
    public int Id {get; set;}
    public string FirstName {get; set;}

    public string LastName {get; set;}
    public string Address {get; set;}

    public string GetFullName() => $"{FirstName} {LastName}";

    public virtual double CalculateMonthlySalary() => 10.5;

    public abstract double CalculateTax();

}

public class FullTimeEmployee : BaseEmployee
{
    public double MonthlySalary {get; set;}
    public override double CalculateMonthlySalary() => MonthlySalary;

    public override double CalculateTax() => 1223;
   
    public new string GetFullName() => $"{base.GetFullName()} - FullTimeEmployee";

}

public class Contractor : BaseEmployee
{
    public double HourlyWage {get; set;}

    public override double CalculateMonthlySalary() => HourlyWage * 100;

    public override double CalculateTax() => 21312;

    public new string GetFullName() => $"{base.GetFullName()} - Contractor";
}

}