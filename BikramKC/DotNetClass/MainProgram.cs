using System;
using DotNetClass;
namespace MainProgram
{
    class MainClass{
        // Data 
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Iterations iteration1 = new Iterations();
            iteration1.DefineLoops();
            Excercise1 ex1 = new Excercise1();
            ex1.printMultipleOfFive();
            */
            Conditions cnd = new Conditions();
            string str = cnd.GetText();
            cnd.PrintHello(str);
            //cnd.GetLargestNumber();
            cnd.PrintVowel();
            cnd.CheckEvenOrOdd();
            cnd.SumOfNaturalNumbers();

        }

    }
}