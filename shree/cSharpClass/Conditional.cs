using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsCondition
{
    public class Conditional
    {
        public void PrintHello()
        {
            Console.Write("Hello World");
        }
        public void CheckIfUserSaysHello()
        {
            string str1 = Console.ReadLine();
            if (str1 == "hello" || str1 == "hi")
                Console.WriteLine("hello");
            else
                Console.WriteLine("How rude.");
        }

        public void GetLargest()
        {
            int x = 1;
            int y = 2;
            int z = 3;
            if (x > y && x > z)
                Console.WriteLine("Largest number is " + x);
            else if (y > z)
                Console.WriteLine("Largest number is " + y);
            else
                Console.WriteLine("Largest number is " + z);

        }

        // ternary operator
        public void UseTernary()
        {
            int x = 0;
            int y = 89;
            x = y > 90 ? 3 : 5;

        }
        //check vowels
        public void CheckVowel()
        {
            char a = Convert.ToChar(Console.ReadLine());

            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                Console.WriteLine("User input vowel");
            else
                Console.WriteLine("User input not vowel");

        }

        public void CheckEvenOdd()
        {
            int num =Convert.ToInt32(Console.ReadLine());
            string result;
            result = (num % 2 == 0) ? "Even number" : "odd number";
            Console.WriteLine(result);
        }
        public void SumOfSquareOfNumber()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i * i;
            }
            Console.WriteLine("sum of squares of number upto " + num + " is " + sum);
        }
    }
    
}
