using LoopsAndConditions;
using Exercise;
using LearningMethods;
using System;

namespace MainProgram 
{
    public class EntryPoint
 {
    public static void Main()
        {
            Methods methods=new Methods();
            //ClassWork classWork=new ClassWork();
            //classWork.CalculateMultipleOfFive();
            Iterations iterations=new Iterations();
            //iterations.DefineLoops();
            Conditionals conditions=new Conditionals();
            //conditions.PrintMessage();
            //conditions.GetLargest();
            //conditions.CheckForVowel();
            //conditions.CalculateSumOfNumber();
            //conditions.CheckOddEvenNumber();
           // iterations.LearnNestedLoops();
           string fullName=methods.GetFullName("Shreya",lastName:"Pradhan"); //named arguements
           Console.WriteLine(fullName);
            //Console.WriteLine("sum is "+methods.AddTwoNumers(12323244,234566));
           (int Min,int Max)result=methods.GetMinMax(new int[]{3,4,5,6,7});
            Console.WriteLine($"Minimum is {result.Min} and Maximum is {result.Max}");

        }
    
 }
}