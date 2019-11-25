using System;

namespace Inheritance
{

    //Concrete Base Class
    //public class BaseEmployee
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string GetFullName() => $"{FirstName} {LastName}";

        //public double CalculateSalary() { return 0.0; }  to make this method overridable we use virtual keyword
        public virtual double CalculateSalary() => 0.0;

        public abstract double CalculateTax();
    }

    public sealed class FullTimeEmployee : BaseEmployee //to not allow the class to be inherited //methods can also be sealed
    {
        public double MonthlySalary { get; set; }

        public override double CalculateSalary() => 45678.0;

        public new string GetFullName() => $"{base.GetFullName()} - FullTime";

        public override double CalculateTax()
        {
            return 567.0;
        }

    }

    public class Contractor : BaseEmployee
    {
        public double HourlyWage { get; set; }

        //method hiding
        //public string GetFullName => $"{FirstName} {LastName} - Contracted";
        // or
        //public new string GetFullName => $"{FirstName} {LastName} - Contracted"; // new keyword is not mandatory but its the convention
        //or
        public new string GetFullName() => $"{base.GetFullName()} - Contractor";

        public override double CalculateTax()
        {
            return 3456.8;
        }

    }

}