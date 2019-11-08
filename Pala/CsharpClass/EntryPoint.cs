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
        /*when LoopsAndConditions are not imported using using keyword
        we can simply write 
        LoopsAndConditions. Iterations iterations = new Iterations(); */

        // Iterations iterations = new Iterations();
        // iterations.DefineLoops();

        //ClassWork exercise1 = new ClassWork();
        //exercise1.PrintMultiplesOfFive();
        Conditionals c = new Conditionals();
        //c.PrintMessage();
        //c.GetLarge();
        //c.Vowels();
        //c.IsEven();
        //c.SumSqNaturalNum();
        Methods m = new Methods();
        //long s = m.AddTwoNumbers(23456,56789);//parameters
        //long s1 = m.AddThreeNumbers(23456,56789,1234);//parameters
        //Console.WriteLine("Sum is = " + s);
        //Console.WriteLine("Sum is = " + s1);
        //string fullName= m.GetFullName(firstName: "Pala",lastName: "Kansakar");//Named Arguments
        //Console.WriteLine(fullName);
        //int min = m.GetMin(new int[] {4,3,5,2,6});
        //(int Min,int Max) minMax = m.GetMinMax(new int[] {4,3,5,2,6});
         //Console.WriteLine($"Minimum = {minMax.Min} and Largest = {minMax.Max}");
        // int mi = minMax.min;
        //int ma = minMax.max;
        float Result = m.AvgDec(1.2F,2.2F,4.5F);
        Console.WriteLine("Average of 3 Decimal number is " + Result);
       
    }
}
}
