using LoopsAndConditions;
namespace MainProgram {

    public class EntryPoint {
        public static void Main () {
            Iterations iter = new Iterations ();
            iter.DefineLoops ();
            PrintMultipleofFive pf = new PrintMultipleofFive();
            pf.printMFive();
        }
    }
}