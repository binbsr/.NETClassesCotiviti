using LoopsAndConditions;
using LearningMethos;
using System;
using Practice;
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
    /*        CheckForEvenNumber evenNum =  new CheckForEvenNumber();
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
            Console.WriteLine($"The Min. number is {result.min} and the Max. number is {result.max}");*/
            DecimalAverage dec = new DecimalAverage();
            decimal average = dec.CalculateAverage(123.54673m,5.678901m,545367.789m);
            Console.WriteLine($"The average is {average}");
            decimal average2=dec.Average(12.5m,15.2456m,1.445m,2,3,7,9,8);
           Console.WriteLine($"The average is {average2}");
          (int F, int M, int U)result = dec.CountEachGenderType();
         Console.WriteLine($"Total Female: {result.F} Total Male: {result.M} Total Unknown: {result.U} ");
     


        }
    }
}
