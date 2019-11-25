namespace Abstract{
    public abstract class BaseEmployees
{
//sealed keyword: if to prevent a class from being inherite 
//keyworkds: base, new, override, abstract, sealed, virtual
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Address { get; set; }

    public string GetFullName() => $"{FirstName} {LastName}";
    public abstract double CalculateMonthlySalary();
    //virtual method has body but not abstract.

}
public class FullEmployees : BaseEmployees
{

    public double MonthlySalary { get; set; }

        public override double CalculateMonthlySalary()
        {
            throw new System.NotImplementedException();
        }
    }


public class Contractor : BaseEmployees
{

    public double MonthlyWedge { get; set; }

        public override double CalculateMonthlySalary()
        {
            throw new System.NotImplementedException();
        }

        public new string GetFullName() => $"{base.GetFullName()} => Contractor";

}


}