using LearningMethods;
using LoopsAndConditions;
using System;
namespace MainProgram
{

public class EntryPoint
{
public static void Main()
    {
   //Iterations iterations = new Iterations();
      //iterations.DefineLoops();
        // Exercise1 exercise =new Exercise1();
        //exercise.ByteArrays();
       // Conditionals c = new Conditionals ();
        //c.CheckInput();
        //c.GetLargest();
        //c.CheckIfVowel();
        //Assignments a = new Assignments ();
        //a.CheckEvenOrOdd();
       // a.SumOfSquares();
       //iterations.LearnNestedLoops();
       Methods m = new Methods();
      // long s = m.AddTwoNumbers(2343234, 23425235);
      //long s = m.Sum(2343234, 23425235);
     // long s1 = m.Sum(2343234, 23425235, 322);
      //Console.Writeline("Sum is " +s);
      //string name = m.GetFullName (lastName:"Shakya",firstName:"Ravi"); //named arguments
      //Console.WriteLine("Your Full Name is: " + name); 
      (int min, int max) result = m.GetMinMax(new int[] {4, 3, 5, 6, 7, 8, 10});
      Console.WriteLine("Min is : " + result.min);
      Console.WriteLine("Max is : " + result.max);
    }
}
}