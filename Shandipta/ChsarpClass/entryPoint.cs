using LoopsAndConditions;
using LearningMethos;
using System;
namespace MainProgram
{
    public class entryPoint
    {
        public static void Main()
        {

            /*   Iterration iter = new Iterration ();
               iter.DefineLoops ();
               MultipleOfFive m = new MultipleOfFive();
               m. Multiple();
               m.Multiple1(100);
               */

          /*   Conditionals c = new Conditionals();
            c.CheckForCorrectString();
            c. GetLargestNumber();
            c.CheckVowel();*/
            CheckForEvenNumber evenNum =  new CheckForEvenNumber();
            evenNum.CheckEvenNumbers();
            SumOfNaturalNumbers nnum = new SumOfNaturalNumbers();
            nnum.NaturalNumbersSum();
            Loops loop = new Loops();
            loop.LearnNestedLoop();
            Methods m = new Methods();
            long sum=m.AddTwoNumbers(211,311111);
            Console.WriteLine(sum);
            long sum1=m.Sum(1,2,3,4,5);
            Console.WriteLine(sum1);
            string fullName = m.GetFullName(lastName:"Rai",firstName:"Shandipta");//named arguments
            Console.WriteLine(fullName);
            int[] value = new int[]{1,1,12,5,5,9};
           (int min,int max) result= m.GetMinMax(value);
            Console.WriteLine($"The Min. number is {result.min} and the Max. number is {result.max}");
        }
    }
}
