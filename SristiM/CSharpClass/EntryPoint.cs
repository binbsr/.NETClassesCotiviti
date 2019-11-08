using LoopsAndConditions;
using LearningMethods;
using System;
namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()//Main method has to be static
        {


            // Iterations iterations = new Iterations();
            // iterations.DefineLoops();
            // Exercise1 exercise =new Exercise1();
            //exercise.ByteArrays();

            //Conditionals c = new Conditionals();
            //c.PrintHello();//Check if user says "Hi" or "Hello"? 
            //c.CheckIfUserSaysHi();
            //c.GetLargest(); //Largest number among 3 numbers?
            //c.CheckVowels(); //Check if entered alphabet is vowel or not?
            //c.EvenNumberCheckTernary();
           // c.SumofSquares();
           // c.LearnNestedLoops();

          Methods m =new Methods();
          //long s=m.AddTwoNumbers(222,3333);
          //Console.WriteLine("Sum is "+s);
          
          //string fn=m.GetFullName("Sristi","Musyaju");
           //string fn=m.GetFullName(lastName:"Musyaju", firstName:"Sristi");//Named arguments, no need to worry about argument ordering
          //Console.WriteLine("The fullname is "+fn);
        
         (int Min,int Max)  result=m.GetMinMax(new int[] {1,2,3,4,5});
         int minimum= result.Min;
         int maximum=result.Max;
         Console.WriteLine($"Minimum={result.Min} and Largest ={result.Max}");
         


        }
    }
}


