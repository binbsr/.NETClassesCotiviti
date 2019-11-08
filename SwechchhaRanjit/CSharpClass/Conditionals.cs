using System;
namespace LoopandConditions
{
    public class Conditionals
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }

        public void InputHello()
        {
            string str;
            str = Console.ReadLine();
            if (str =="hello" || str == "Hello")
            {
                Console.WriteLine("Valid String");
            }
            else
            {
                Console.WriteLine("Invalid String");
            }
        }

        public void GetLargest()
        {
            long x = 34224242;
            long y = 34224247;
            long z = 34254247;

            if (x>y && x>z)
            {
                Console.WriteLine(x+ " is largest");
            }
            else if (y>z)
            {
                Console.WriteLine(y+ " is largest");  
            }
            else
            {
                Console.WriteLine(z+ " is largest");
            }
        }

        public void UseTernary()
        {
            int x;
            byte y = 90;
            if (y>90)
                x=3;
            else
                x=5;
            x = y > 90 ? 3 : 5;
        }

        public void CheckVowel()
        {
            string vowel;
            
            vowel = Console.ReadLine();
            if (vowel == "a" || vowel == "e" || vowel =="i" || vowel =="o" || vowel =="u" )
                Console.WriteLine("Given letter is vowel:");
            else
                Console.WriteLine("Given letter is not a vowel");
        }

        public void CheckEvenNm()
        {
            int evennm;
            Boolean checkeven;
             evennm = int.Parse(Console.ReadLine()); 
             checkeven = evennm % 2 ==  0 ? true : false;
             Console.WriteLine(evennm + " is even number");
        }

        public void SumSquaresNm()
        {
            int n;
            int i;
            int sum = 0;
            Console.WriteLine("Give value of n");
            n = int.Parse(Console.ReadLine());
            for ( i = 1; i< n ; i++)
            {
               sum+= i*i;
            }
        Console.WriteLine("Sum of squares of first natural numbers are: "+ sum);
        }
    }
}