using Inheritance;

namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()
        {
            BaseEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Bishnu";
            fte.LastName = "Rawal";            
            System.Console.WriteLine(fte.GetFullName());
            System.Console.WriteLine(fte.CalculateMonthlySalary());

            Contractor contra = new Contractor();
            contra.FirstName = "Shree Krishna";
            contra.LastName = "Gurung";

            System.Console.WriteLine(contra.GetFullName());
                       

        }
    }
}
