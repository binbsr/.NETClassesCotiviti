using LoopsAndConditions;
namespace MainProgram {

    public class EntryPoint {
        public static void Main () {
            /* 
            Iterations iter = new Iterations ();
            iter.DefineLoops ();
            PrintMultipleofFive pf = new PrintMultipleofFive();
            pf.printMFive();
            */

            Conditionals c = new Conditionals();
            /*c.PrintHello();*/
            c.CheckIfUserSaysHi();
            c.GetLargest();
            c.CheckVowel();
            CheckForEvenNumbers evenNumbers = new CheckForEvenNumbers();
            evenNumbers.CheckForEvenNumber();
            SumOfNaturalNumbers sum = new SumOfNaturalNumbers();
            sum.NaturalNumbersSum();
            
        }
    }
}