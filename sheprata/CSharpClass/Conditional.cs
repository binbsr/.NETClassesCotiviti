using System;
namespace LoopsAndConditions
{
    public class Conditionals
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello World");
        }

//if user enters valid 
        public void CheckString()
        {
           Console.WriteLine("How do you greet ?");
           String str =  Console.ReadLine();
           if (str == "H1" || str == "Hello")
           {
               Console.WriteLine("This is valid string");
           }
           else
           {
               Console.WriteLine("Please enter valid string");
           }
        }

        public void GetLargest()
        {
            long x = 342342242;
            long y = 342342;
            long z =342;

            if(x > y && x > z)
            {
                Console.WriteLine("x is greater " + x);
            }
            else if (y > z)
            {
                Console.WriteLine("y is greater " + y);
            }
            else
            {
                Console.WriteLine("z is greater " +z);
            }
        }

        public void UseTernary()
        {
            int x = 0;
            byte y = 89;
            x = y > 90 ? 3:5 ;    
        }

        public void Checkvowels()
        {
            char[] vowel1 = new char[] {'a','e','i','o','u'};
            
            Console.WriteLine("Enter string to calculate vowel : ");
            String input = Console.ReadLine();

            char w = System.Convert.ToChar(input[0]);

            if(w == vowel1[0])
            {
                Console.WriteLine(w + " is vowel ");
            }
            else
            {
                Console.WriteLine( w +" is not vowel ");
            }

          /*  String vowel = Console.ReadLine();

            if(vowel == "a"|| vowel == "e" || vowel == "i" || vowel == "o" || vowel == "u")
            {
                Console.WriteLine("this string is vowel");
            }
            else 
            Console.WriteLine ("this is not vowel"); */
        }

        //Check if entered number is even or not (use ternary operator)?

         public void isEven()
             {
            int x = 0;
            byte y = 89;
            x = y > 90 ? 3:5 ;  
                 
            Console.WriteLine("Enter any number to check even or not");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine(num%2==0 ? "it is even" : "it is odd");
             }
         

        //Calculate the sum of squares of first n natural numbers.
        public void nSumOfSquares(){
        int num;
        int sum = 0;

        Console.WriteLine("Enter number for sum of squares: ") ;
        num =  Int32.Parse(Console.ReadLine());

         for(int i = 1 ; i < num+1 ; i++)
         {
             int sqr = i*i;
             sum =  sum + sqr;
         }
         
        Console.WriteLine("Sum of Squares of given n natural number is " + sum);
        }
    }
}