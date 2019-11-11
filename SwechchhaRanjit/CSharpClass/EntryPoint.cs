//using LoopandConditions;
using System;
using LearningMethods;
using LoopandConditions;
//using MultipleFiveNumbers;
using Practice;

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
            sumsq.SumSquaresNm();
            
            Methods m = new Methods();
            long s = m.AddTwoNumbers(234234, 234234);
            Console.WriteLine("Sum is " + s);
            long s1 = m.AddThreeNumbers(234234, 234234, 234234);
            Console.WriteLine("Sum is " + s1);
            long s2 = m.Sum(234234,234234,34,34);
            Console.WriteLine("Sum is " + s2);

            //Named Arguments
            string name =m.GetFullName(lastName: "Ranjit", firstName: "Swechchha");
            Console.WriteLine("Name "+ name);

            int min = m.GetMin(new int[] { 4, 3, 5, 2, 6 });
            
            //tuple
            (int min ,int max ) result = m.GetMinMax(new int[] { 4, 3, 5, 2, 6 });
            int m1 = result.min;
            int m2 = result.max;

            Console.WriteLine($"Minimum = (result.min) and Largest = (result.max)"); */

            Exercise2 exercise2 = new Exercise2();
            decimal average = exercise2.CalculateAvgThreeArguments(12.3M, 23.45M, 45.678M);
            Console.WriteLine("The average of given three arguments is: " + average);

            decimal avg = exercise2.CalculateAvgNArguments(new decimal[] { 12.3M, 23.45M, 45.678M });
            Console.WriteLine("Average of N arguments is: " + avg);

            (int male, int female, int others) result1 = exercise2.CountGenderType();
            Console.WriteLine($"Total count of Males =  {result1.male} , Total count of Females = {result1.female} and Total count of Others = {result1.others}");
        }

    }
}
