using LoopandConditions;
//using MultipleFiveNumbers;
namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main ()
        {
            //Iterations iterations = new Iterations();
            //iterations.DefineLoops();
            //Exercise1 exercise1 = new Exercise1();
            //exercise1.Numbers();
            Conditionals c = new Conditionals();
            c.PrintHello();
            Conditionals input = new Conditionals();
            input.InputHello();
            Conditionals largestnm = new Conditionals();
            largestnm.GetLargest();
            
            Conditionals c = new Conditionals();
            c.CheckVowel();
            Conditionals even = new Conditionals();
            even.CheckEvenNm();
            Conditionals sumsq = new Conditionals();
            sumsq.SumSquaresNm();

        }

    }

}
