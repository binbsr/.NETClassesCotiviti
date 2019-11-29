using System;

namespace LoopsAndConditions
{
    public class Conditionals
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }

        // Check if user enters "Hi"
        public void CheckIfUserSaysHi()
        {
            string input = Console.ReadLine();
            if (input == "Hi" || input == "Hello")
            {
                Console.Write("Hi");
            }
            else
            {
                Console.Write("How rude.");
            }
        }

        public void GetLargest()
        {
            int x = '2';
            long y = 34238675;
            long z = 34234101;

            if (x > y && x > z)
            {
                Console.WriteLine(x + " is largest");
            }
            else if (y > z)
            {
                Console.WriteLine(y + " is largest");
            }
            else
            {
                Console.WriteLine(z + " is largest");
            }
        }

        public void UseTernary()
        {
            int x = 0;
            byte y = 89;            
            x = y > 90 ? 3 : 5;
        }
    }
}