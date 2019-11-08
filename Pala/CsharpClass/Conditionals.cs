using System;

namespace LoopsAndConditions

{
    public class Conditionals
    {
        public void PrintMessage()
        {
            string msg = Console.ReadLine();
            if (msg == "HelloWorld" || msg == "Hello")
                Console.WriteLine("HelloWorld");
            else if (msg == "Hi")
                Console.WriteLine("Hi");
            else
                Console.WriteLine("NotHelloWorld");

        }

        public void GetLarge()
        {
            long x = 324234;
            long y = 767866;
            long z = 563434;

            if (x > y && x > z)
                Console.WriteLine(x + "is Greater");
            else if (y > x)
                Console.WriteLine(y + "is Greater");
            else
                Console.WriteLine(z + "is Greater");

        }
        public void UseTernary()
        {
            int x = 0;
            byte y = 89;
            x = y > 90 ? 3 : 5;
        }
        public void Vowels()
        {
            char ReadChar = Convert.ToChar(Console.ReadLine());
            char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };
            bool isvowel = false;
            foreach (char x in Vowels)
            {
                if (ReadChar == x)
                {
                    isvowel = true;
                }


            }

            if (isvowel == true)
                Console.WriteLine("it is a vowel");
            else
                Console.WriteLine("Not a vowel");


        }
        public void IsEven()
        {
            string result;
            int num = Convert.ToInt32(Console.ReadLine());
            result = (num%2==0) ? "even" : "odd";
            Console.WriteLine(result);
        }
        
        public void SumSqNaturalNum()
        {
            int sum = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=num;i++)
            {
                sum=sum+(i*i);
            }
            Console.WriteLine(sum + " is sum of Square of natural number =" + num);
        }
    }
}




