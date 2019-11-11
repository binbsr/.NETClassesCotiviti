using LoopsAndConditions;
using Exercise;
using System;
using LearningMethods;
namespace MainProgram
{
    class EntryPoint
    {
        public static void Main()
        {
            /*  Iterations iterations = new Iterations();
              iterations.DefineLoops();
              */
            /*
             Exercise1 e1 = new Exercise1();
             e1.PrintMultipleOfFive();
             */

            /* Console.WriteLine("dsfs");
             Console.WriteLine("dsfs");
             Console.Write("dsfs");

             Console.ReadLine();
             */

            //Conditionals c = new Conditionals();
            //c.PrintHello();
            //c.CheckHello();
            //c.GetLargest();
            // c.checkVowels();
            //c.CheckEven();
            //c.SumOfSquares();

            // Iterations i = new Iterations();
            //i.LearnNestedLoops();    
           /*Methods m = new Methods();
            long s = m.AddTwoNumbers(1232132, 12321321);
            Console.WriteLine("Sum is " + s);

            long s1 = m.AddThreeNumbers(123231,21321321,21321321);
            Console.WriteLine("Sum is "+ s1);

            long s2 = m.Sum(123231,21321321,21321321);
            Console.WriteLine("Sum is "+ s2); 

            string fullName = m.GetFullName("Nitin","Malla");
            m.GetFullName(lastName:"Nitin", firstName:"Malla"); // named arguments
            Console.WriteLine("Full Name is "+ fullName);   

            (int Min,int Max) result = m.GetMinMax(new int[] {4,3,5,2,8});

            Console.WriteLine($"Minimum = {result.Min}, Maxmimum = {result.Max}");
            */

            Exercise2 e = new Exercise2();
             decimal d = e.CalcualteAverage(12.3M,12321.213M,21321.234M);
             Console.WriteLine("average is :" +d);

             decimal avg  = e.CalcualteAvgOfAll(new decimal[] {12.3M,12321.213M,21321.234M});
              Console.WriteLine("average is :" +avg);

             (int male,int female, int other) result = e.CountGender();

             Console.WriteLine($"No.of Males = {result.male} , No. of Females = {result.female} and No. of others = {result.other}");



        }
    }
}
