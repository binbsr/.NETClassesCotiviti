using System;
using GetMethods;
namespace DotnetHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageOfNumbers obj1 = new AverageOfNumbers();
            AverageOfNumbers obj2 = new AverageOfNumbers();

            double showAverageOf3 = obj1.GetAverageOf3(12.5, 12.5, 12.5);
            Console.WriteLine("The average of 3 numbers is :" + showAverageOf3);

            double showAverageOfN = obj1.GetAverageOfN(new double[] { 12.5, 12.5, 12.5,12.5,15.5 });
            Console.WriteLine("The average is all the numbers is :" + showAverageOfN);

            GenderCount obj3=new GenderCount();
             (int mcount, int fcount, int ocount) result= obj3.DisplayCount();
            Console.WriteLine("Male:: "+result.mcount+" Female:: "+result.fcount+" Others:: "+result.ocount);

        }
    }
}
