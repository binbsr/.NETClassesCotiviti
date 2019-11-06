using LoopandConditions;
using MultipleFiveNumbers;
namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main ()
        {
            Iterations iterations = new Iterations();
            iterations.DefineLoops();
            Exercise1 exercise1 = new Exercise1();
            exercise1.Numbers();
        }

    }

}
