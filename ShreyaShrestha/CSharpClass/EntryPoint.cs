using LoopsAndConditions;
using LearnNewMethods;
using Exercise;
using System;

namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()
        {
            /*when LoopsAndConditions are not imported using using keyword
            we can simply write 
            LoopsAndConditions. Iterations iterations = new Iterations(); */

            Iterations iterations = new Iterations();
            // iterations.DefineLoops();

            // ClassWork exercise1 = new ClassWork();
            // exercise1.PrintMultiplesOfFive();

            Conditionals conditionals = new Conditionals();
            //conditionals.CheckIfUserSaysHello();
            //conditionals.ReturnLargestNumber();
            //conditionals.CheckVowel();
            //conditionals.CheckIfInputCharIsVowel();
            //conditionals.CheckEvenNumber();
            conditionals.CalculateTheSumOfFirstNNaturalNumbers();
            //iterations.LearnNestedLoops();
            Methods learnNewMethods = new Methods();
            //long sum = learnNewMethods.ReturnSum(3456,46768);
            //Console.WriteLine("Sum of two long numbers is " + sum);
            // long sum = learnNewMethods.Sum(10,2,4);
            // Console.WriteLine(sum);
            //string fullName = learnNewMethods.GetFullName(firstName:"Shreya", lastName:"Shrestha"); //named Arguments
            // Console.WriteLine(fullName);

            //Calling using tuple
            //(int Min, int Max) result = learnNewMethods.GetMinAndMax(new int[]{3,6,4,2,8,1});
            //Console.WriteLine($"{result.Min}, {result.Max}");

            //average of 3 decimal numbers
            //Console.WriteLine(learnNewMethods.GetAverageOfThreeDecimalNumber(2.3M,8.9M,5.6M));

            //average of n decimal numbers
            // Console.WriteLine(learnNewMethods.GetAverageOfNDecimalNumbers(new decimal[] { 0.3M, 2.5M, 5.6M, 6.9M }));
            // Console.WriteLine(learnNewMethods.GetAverageOfNDecimalNumbers(new decimal[] {2.9M,8.5m }));

            //genderCount
            // (int femaleCount, int maleCount, int nullCount) gendersCount = learnNewMethods.GetGenderCount();
            // Console.WriteLine($"Female count is {gendersCount.femaleCount}, Male count is {gendersCount.maleCount} and Null count is {gendersCount.nullCount}");
        }
    }

}

