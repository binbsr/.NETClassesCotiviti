using System;
using LoopsAndConditions;  
using LearningMethods;
namespace MainProgram
{
public class EntryPoint
{
public static void Main() // main methods has to be static
    {
        //Iterations iterations = new Iterations ();
        //iterations.DefineLoops();
        
        //Exercise1 exercise = new Exercise1 ();
        //exercise.ByteArrays();
        // Conditionals c = new Conditionals();
        // c.PrintHello();
        
        //Exercise2 obj2 = new Exercise2();
        // obj2.ConditionalPrint();
        //obj2.GetLargest();
        //obj2.UseTernary();
        //obj2.CheckVowel();
        //obj2.UseTernaryEvenOdd();
        //obj2.SumofSquares();
        
        Exercise3 obj3 = new Exercise3();
        //obj3.LearnNestedLoops();
        //Methods m = new Methods();
        //long sum = m.AddTwoNumbers(273642,463729);
        //Console.WriteLine(sum);
        //Console.WriteLine ("Sum is " + sum);
        //named arguments
        //string fullname = m.GetFullName(lastname: "Amatya", firstName: "Ayushma");
        //Console.WriteLine (fullname);
        //(int Min,int Max) result = m.GetMinMax(new int[] {4,3,5,2,6});
        //Console.WriteLine (result);
        //Console.WriteLine($"Minimum value = {result.Min} and Maximum value = {result.Max}");
        double avg = obj3.AverageofDecimalNumbers(12.5, 12.5, 12.5);
        Console.WriteLine(avg);

        Exercise3 obj4 = new Exercise3();
        long sum = obj4.AverageofN(8,8,8,8,8);
        Console.WriteLine(sum);

        Exercise3 obj5=new Exercise3();
        obj5.CountGender();
    }
}
}
