using System;
using LoopsCondition;
using Exercise1;
using LearningMethods;
using Exercise3;
namespace cSharpClass
{
    class Program
    {
        /*   public static void Main()
           {
               Iteration iternation1 = new Iteration();
               iternation1.DefineLoops();
           }

               public static void Main()
           {
               Multiple mul = new Multiple();
               mul.PrintMultiple();

           } */

        /*public static void Main()
        {
            Conditional c1 = new Conditional();
             c1.CheckIfUserSaysHello();
             c1.GetLargest();
             c1.UseTernary();
             c1.CheckVowel();
            c1.CheckEvenOdd();
            c1.SumOfSquareOfNumber();

            Methods m1 = new Methods();

             long a, b;
             a = Convert.ToInt64(Console.ReadLine());
             b= Convert.ToInt64(Console.ReadLine());

             long sum = m1.SumOfTwoNumber(a, b);
             Console.WriteLine("Sum of two numbers = " + sum);

            Console.WriteLine("Sum of two numbers = " +m1.Sum(1, 2, 3));
            Console.WriteLine("Sum of two numbers = " +m1.Sum(9, 8));

            m1.GetFullName(lName: "Gurung", fname: "Shree");        // IT IS CALLED NAMED ARGUMENT - this is used to remove argument passing order confusion
            
            (int Min, int Max) result =  m1.GetMinMax(new int[] { 4, 5, 3, 1, 7, 8, 19, 10 });  // this is same as array define and intialize
            Console.WriteLine($"Minimum number = { result.Min} and Maximum number = { result.Max}");  // return minimum value
           }*/


        // calculation of average of three number using normal method
        /* public static void Main()
         {
             decimal a, b, c, avg;
             AverageOfThreeNumber avg1 = new AverageOfThreeNumber();
             Console.WriteLine("Please enter any three number to calculate the average : ");
             a = Convert.ToDecimal(Console.ReadLine());
             b = Convert.ToDecimal(Console.ReadLine());
             c = Convert.ToDecimal(Console.ReadLine());
             avg=avg1.GetAvgOfThreeNum(a,b,c);
             Console.WriteLine($"Average of three number = {avg}");
         } 

        // calculation of average of three number using VARIABLE ARGUMENT method
         public static void Main()
         {
            AverageOfThreeNumber avg1 = new AverageOfThreeNumber();
            Console.WriteLine($"Average of 2 numbers = {avg1.GetAverageOfThreeNum1(2, 3)}");
            Console.WriteLine($"Average of 3 numbers = {avg1.GetAverageOfThreeNum1(10, 20, 30)}");
            Console.WriteLine($"Average of 4 numbers = {avg1.GetAverageOfThreeNum1(10, 20, 30, 40)}");
            Console.WriteLine($"Average of 5 numbers = {avg1.GetAverageOfThreeNum1(1,2,3,4,5)}");
         }      */

        public static void Main()
        {
            Gender g = new Gender();
            (int maleCount, int femaleCount, int otherCount)result = g.GenderCollectionCount(new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' });
            Console.WriteLine($"Male Count = {result.maleCount} and Female Count = { result.femaleCount} and Other Count = { result.otherCount}");
        }
    }
}
