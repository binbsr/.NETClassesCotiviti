using LoopsAndConditions;
using LearningMethods;
using System;
namespace MainProgram {

    public class EntryPoint {
        public static void Main () {
         
            /*Iterations iter = new Iterations ();
            iter.DefineLoops ();
            iter.LearnNestedLoops ();
            PrintMultipleofFive pf = new PrintMultipleofFive();
            pf.printMFive();
            */
            

            /*Conditionals c = new Conditionals();*/
            /*c.PrintHello();*/
            /*c.CheckIfUserSaysHi();
            c.GetLargest();
            c.CheckVowel();
            CheckForEvenNumbers evenNumbers = new CheckForEvenNumbers();
            evenNumbers.CheckForEvenNumber();
            SumOfNaturalNumbers sum = new SumOfNaturalNumbers();
            sum.NaturalNumbersSum();
            */

            Methods m = new Methods();
            //long s = m.AddThreeNumbers(1,9,1);
            long s = m.sum(2,2,1);
            Console.WriteLine("Sum is "+s);
            

            //Named arguments
            string name = m.GetFullName(lastName: "Shakya", firstName: "Kajol");
            Console.WriteLine("Full Name is "+name+ ".");

            (int Min,int Max) result = m.GetMinMax(new int[] {4, 3, 5, 2, 6});
            /*int m1 = result.Min;
            int m2 = result.Max;
            Console.WriteLine("Minimum number is "+m1+ " and maximum number is "+m2+".");
            */
            /*Console.WriteLine("Minimum number is" +result.Min);
            Console.WriteLine("Maximum number is "+result.Max);*/

            Console.WriteLine($"Minimum no. is {result.Min} and the maximum no. is {result.Max}");

        }
    }
}