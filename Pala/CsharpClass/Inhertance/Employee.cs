//sealed -- cannot be inherated in class 
//abstrct similatr to interface using override
public abstract class BaseEmployee//instance can't be made and called  using abstract method
{
    public int id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

    public string GetFullName() => $"{FirstName} {LastName}";
    //public abstract double CalculateMonthlysalary();// must enforce this method inside class
      public virtual double CalculateMonthlysalary()
    {
        return 0.0;
    }
    public abstract double CalculateTax();

}
public sealed class FullTimeEmployee : BaseEmployee // concrete base class
{

    public double MonthSalary { get; set; }

    public override double CalculateMonthlysalary() => 34234.7;
    
    //public new string GetFullName() => $"{FirstName} {LastName} - Fulltime";// Method hiding- base class method hude by derived class
    public new string GetFullName() => $"{base.GetFullName()}- Fulltime";//base implementation when using method of base class
    public override double CalculateTax()=>3245; 

}

public sealed class Contractor : BaseEmployee
{

    public double HourlyWage { get; set; }

    public override double CalculateMonthlysalary()=>4567.888;
    

    public new string GetFullName() => $"{base.GetFullName()}- contractor";
    public override double CalculateTax()=>3245;

}