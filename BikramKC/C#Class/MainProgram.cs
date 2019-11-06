using System;
using C_Class;
namespace MainProgram
{
    class MainClass{
        // Data 
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Iterations iteration1 = new Iterations();
            iteration1.DefineLoops();
            Excercise1 ex1 = new Excercise1();
            ex1.printMultipleOfFive();
        }

    }
}
