namespace Inheritance
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string GetFullName() => $"{FirstName} {LastName}";

        //virtual keyword helps to override the method.
        public virtual double CalculateMonthlySalary()
        {
            return 0.0;
        }
        public abstract double CalculateTax();
        
    }

    public class FullTimeEmployee : BaseEmployee
    {
        public double MonthlySalary { get; set; }

        public override double CalculateMonthlySalary() => MonthlySalary;
        
        public override double CalculateTax() => 1232.0;
        
        //method hiding
        public new string GetFullName() => $"{FirstName} {LastName} FullTime";

    }
    public class Contractor : BaseEmployee
    {
        // public Contractor()
        // {
        // }

        // public Contractor(double hourlyWage)
        // {
        //     HourlyWage = hourlyWage;
        // }

        public double HourlyWage { get; set; }

        public override double CalculateMonthlySalary() => HourlyWage *160;
        

        public override double CalculateTax() => 12.32;

        public new string GetFullName() => $"{base.GetFullName()} - Contractor";

    }
}

