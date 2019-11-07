using System;
namespace DotNetClass
{
    public class Conditions
    {
        public void PrintHello(string str)
        {
            if (str == "Hello")
            {
                Console.WriteLine("Valid String");
            }
            else
            {
                Console.WriteLine("J paye tei enter garchas gadha!!");
            }

        }
        public string GetText()
        {
            string s = Console.ReadLine();
            return s;

        }
        public void GetLargestNumber()
        {
            long x = Convert.ToInt64(Console.ReadLine());
            long y = Convert.ToInt64(Console.ReadLine());
            long z = Convert.ToInt64(Console.ReadLine());
            long[] number = { x, y, z };
            long max = x;
            for (int i = 0; i < 3; i++)
            {
                if (number[i] > max)
                {
                    max = number[i];

                }
            }
            Console.Write("The max value among 3:" + max.ToString());

        }
        public void PrintVowel()
        {
            Console.WriteLine("Please Enter a character: ");
            char a = Convert.ToChar(Console.ReadLine());
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            bool isVowel = false;
            foreach (char c in vowels)
            {
                if (a == c)
                {
                    isVowel = true;                    
                }
            }
            if (isVowel)
            {
                Console.WriteLine("You entered Vowel: " + a.ToString());
            }
            else
            {
                Console.WriteLine("You entered Consonent: " + a.ToString());
            }
        }

    }
}