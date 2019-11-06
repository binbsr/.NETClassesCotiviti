using LoopsAndConditions;
using Exercise;

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

        ClassWork exercise1 = new ClassWork();
        exercise1.PrintMultiplesOfFive();
    }
}

}

