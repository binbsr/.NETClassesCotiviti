namespace Inheritances
{
    public class BaseEmployee
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MonthlySalary { get; set; }
        public string GetFullName() => $"{FirstName} {LastName}";
        public virtual double CalculateMonthlySalary()
        {
            return 0.0;
        }

    
    }
    public class FullTimeEmployee : BaseEmployee
    {
        private string monthlySalary;

        public new string MonthlySalary { get => monthlySalary; set => monthlySalary = value; }
        public new string GetFullName() => $"{base.GetFullName()} - FullTime";
        public override double CalculateMonthlySalary()
        {
            return 123.3434;
        }
    }
    public class Contractor : BaseEmployee
    {
        public string HourlyWage { get; set; }
        public new string GetFullName() => $"{base.GetFullName()} - Contractor";

    }
}