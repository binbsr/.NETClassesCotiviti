using LoopsAndConditions;
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
        

        }
    }
}