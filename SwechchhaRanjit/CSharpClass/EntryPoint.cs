//using LoopandConditions;
//using MultipleFiveNumbers;
using Practice;
using System;
namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()
        {
            /*Iterations iterations = new Iterations();
            iterations.DefineLoops();
            Exercise1 exercise1 = new Exercise1();
            exercise1.Numbers();
            Conditionals h = new Conditionals();
            h.PrintHello();
            Conditionals input = new Conditionals();
            input.InputHello();
            Conditionals largestnm = new Conditionals();
            largestnm.GetLargest();
            
            Conditionals c = new Conditionals();
            c.CheckVowel();
            Conditionals even = new Conditionals();
            even.CheckEvenNm();
            Conditionals sumsq = new Conditionals();
            sumsq.SumSquaresNm();*/

            Exercise2 exercise2 = new Exercise2();
            decimal average = exercise2.CalculateAvgThreeArguments(12.3M, 23.45M, 45.678M);
            Console.WriteLine("The average of given three arguments is: " + average);

            decimal avg = exercise2.CalculateAvgNArguments(new decimal[] { 12.3M, 23.45M, 45.678M });
            Console.WriteLine("Average of N arguments is: " + avg);

            (int male, int female, int others) result = exercise2.CountGenderType();
            Console.WriteLine($"Total count of Males =  {result.male} , Total count of Females = {result.female} and Total count of Others = {result.others}");
        }

    }
}
