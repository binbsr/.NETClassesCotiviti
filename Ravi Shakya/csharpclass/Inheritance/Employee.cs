namespace Inheritance
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string GetFullName() => $"(FirstName) (LastName)";
        public virtual double CalculateMonthlySalary()
        {
            return 0.0;
        }
        public abstract double CalculateTax();
        
    }

    public class FullTimeEmployee : BaseEmployee
    {
        public double MonthlySalary { get; set; }

        public override double CalculateMonthlySalary()
        {
            throw new System.NotImplementedException();
        }

        public override double CalculateTax()
        {
            throw new System.NotImplementedException();
        }

        public new string GetFullName() => $"(base.GetFullName()) - FullTimeEmployee";

    }
    public class Contractor : BaseEmployee
    {
        public Contractor(string hourlyWage)
        {
            HourlyWage = hourlyWage;
        }

        public double HourlyWage { get; set; }

        public override double CalculateMonthlySalary()
        {
            return HourlyWage*22;
        }

        public override double CalculateTax()
        {
            throw new System.NotImplementedException();
        }

        public new string GetFullName() => $"(base.GetFullName() - Contractor";

    }
}

