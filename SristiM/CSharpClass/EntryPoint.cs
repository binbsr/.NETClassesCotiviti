using LoopsAndConditions;
using LearningMethods;
using System;

//comment ctrl+K+C and uncomment ctrl+K+U
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
        
        //Calculate Min/Max from the given set of numbers
        //  (int Min,int Max)  result=m.GetMinMax(new int[] {1,2,3,4,5});
        //  int minimum= result.Min;
        //  int maximum=result.Max;
        //  Console.WriteLine($"Minimum={result.Min} and Largest ={result.Max}");

        //Calculate average of the numbers provided
        decimal avg= m.GetAverage(new decimal[] {9.5M,6.5M,5.5M});
        Console.WriteLine("The average of the provided input numbers="+avg); 

        //Determine gender of the provided set
        (int NoOfMales, int NoOfFemales, int NoOfOthers) result=
        m.DetemineGender(new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' });
        Console.WriteLine($"No of Males={result.NoOfMales} and No of Females={result.NoOfFemales} and No of Others={result.NoOfOthers}");


        }
    }
}


