namespace Abstract
{
    public abstract class BaseEmployees
    {
        //sealed keyword: if to prevent a class from being inherite 
        //keywords: base, new, override, abstract, sealed, virtual
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
        //The new keyword is used to hide a method, property, indexer, or event of the base class into the derived class.
        //If a method is not overriding the derived method then it is hiding it. 
        //A hiding method must be declared using the new keyword. Shadowing is another commonly used term for hiding.

    }


}