namespace Inheritances {

    public abstract class BaseEmployee
    //abstract class need not have abstract members within
    //cannot create instance of abstract class similar to inheritance
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string GetFullName () => $"{FirstName} {LastName}"; //lamda expression

        public virtual double CalculateMonthlySalary () {
            return 0.0;
        }

        //abstract method must be implemented/override by derived class unlike interface
        //virtual method are overridable but not necessarily be overridden
        public abstract double CalculateTax ();

    }

    public sealed class FullTimeEmployee : BaseEmployee {
        //once sealed the class cannot be inherited
        public double MonthlySalary { get; set; }

        // public new string GetFullName () => $"(FirstName)(LastName) - FullTime"; 
        //Method Hiding:Derived method hides the base method
        //use new keyword

        public new string GetFullName () => $"{base.GetFullName()}- Fulltime";
        public override double CalculateMonthlySalary () => 384958435.0;
        public override double CalculateTax () => 999;

    }

    public class Contractor : BaseEmployee {
        public double HourlyWage { get; set; }

        public override double CalculateMonthlySalary () => HourlyWage * 160;

        public override double CalculateTax () => 10000;

    }

}

//DRY principal--Dont Repeat Yourself