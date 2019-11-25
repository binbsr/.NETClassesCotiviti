namespace Inheritance
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string GetFullName() => $"{FirstName} {LastName}";
        public virtual double CalculateMonthlySalary() => 0.0;
    }

    public sealed class FullTimeEmployee : BaseEmployee
    {
        public double MonthlySalary { get; set; }

        public override double CalculateMonthlySalary() => 32423.3;
        public double CalculateTax() => 3234;
        public new string GetFullName() => $"{base.GetFullName()} - FullTime";        
    }

    public class Contractor : BaseEmployee 
    {
        public double HourlyWage { get; set; }

        public override double CalculateMonthlySalary() => HourlyWage * 160;
        public override double CalculateTax() => 3234.3;
        public new string GetFullName() => $"{base.GetFullName()} - Contractor";        

    }
} 