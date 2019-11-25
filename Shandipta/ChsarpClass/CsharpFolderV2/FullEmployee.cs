public abstract class BaseEmployees
{

    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Address { get; set; }

    public string GetFullName() => $"{FirstName} {LastName}";
    // public abstract double CalculateMonthlySalary();


    //virtual keyword allow derived classes to override methods of baseclasses
    public virtual double CalculateMonthlySalary()
    {
        return 0.0;
    }
}
//Astract keyword doesnt allow to create an instace of a class
//use on base classes so only instance of concret classes  are allowed
//abstract in method means the classe(derived) which inheritance base class must use that method aswell


public class FullEmployees : BaseEmployees
{

    public double MonthlySalary { get; set; }

    /*   public override double CalculateMonthlySalary()
       {
           throw new System.NotImplementedException();
       }*/
    public override double CalculateMonthlySalary() => 50000000;

    //derived class hide base class 
    //called method hiding
    //method overridding
    // public new string GetFullName() => $"{base.GetFullName()} => FullEmployees"; 
    // public new string GetFullName() => $"{FirstName} {LastName} => FullEmployees"; 
}


public class Contractor : BaseEmployees
{

    public double MonthlyWedge { get; set; }

    /*   public override double CalculateMonthlySalary()
       {
          return MonthlyWedge*22;
       }
   */
    public new string GetFullName() => $"{base.GetFullName()} => Contractor";

}


