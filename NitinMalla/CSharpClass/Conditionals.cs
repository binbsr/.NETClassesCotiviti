namespace LoopsAndConditions
{
    using System;
    public class Conditionals
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello World");
        }

        public void CheckHello()
        {
            string input;
            input = Console.ReadLine();

            if (input == "Hello" || input == "Hi")
            {
                Console.WriteLine("valid string");
            }
            /*else if (input == "Hi")
            {
                Console.WriteLine("valid string");

            }*/
            else
            {
                Console.WriteLine("invalid string");
            }

        }

        public void GetLargest()
        {
            long x = 34243242;
            long y = 3428675;
            long z = 34224101;

            if (x > y && x > z)
            {
                Console.WriteLine(x + " is the largest ");
            }
            else if (y > z)
            {
                Console.WriteLine(y + " is the largest");
            }
            else
            {
                Console.WriteLine(z + " is the largest");
            }
        }

        public void UseTernary()
        {
            int x;
            byte y = 90;
            /* if (y >90)
                 x = 3;
             else
                 x = 5;
             */
            x = y > 90 ? 3 : 5;
        }

        public void checkVowels()
        {
            //string x;
            bool vowel = false;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string input = Console.ReadLine();
            char x = char.Parse(input);

            /* if (x == 'a'||x == 'e'||x == 'i'||x == 'o'||x == 'u'||x == 'A'||x == 'E'||x == 'I'||x == 'O'||x == 'U')
             Console.WriteLine(x+"is a vowel");
            else
            {
                Console.WriteLine(x+" is not a vowel");
            }*/

            /*   for (int i=0; i<vowels.Length; i++)
              {
                   char v = vowels[i];
                   if (x == v)
                   {
                       vowel = true;
                   }
              } 
            */
            foreach (char a in vowels)
            {
                if (x == a)
                {
                    vowel = true;
                }
            }
            if (vowel == true)
            {
                Console.WriteLine(x + " is a vowel");
            }
            else
            {
                Console.WriteLine(x + " is  not a vowel");
            }

        }

        public void CheckEven()
        {
            int num;
            bool even = false;
            Console.Write("Enter any Number: ");
            string input = Console.ReadLine();
            num = int.Parse(input);
            even = num % 2 == 0  ? true : false;
            if (even == true)
                Console.WriteLine(num + " is an even number");
            else
                Console.WriteLine(num + " is an odd number");
        }

        public void SumOfSquares()
        {
            int num;
            Console.Write("Enter any Number:");
            string input = Console.ReadLine();
            num = int.Parse(input);
            long sum = 0;
            for(int i=0; i<=num; i++)
            {
               sum = sum + (i*i);
            }
            Console.Write("Sum of squares of first  "+ num +" natural numbers is " + sum);
        }

    }
}
