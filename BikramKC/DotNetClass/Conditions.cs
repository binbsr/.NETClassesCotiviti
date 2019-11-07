using System;
namespace DotNetClass
{
    public class Conditions
    {
        public void PrintHello(string str)
        {
            
            if (str == "Hello" || str == "hi")
            {
                Console.WriteLine("Valid String");
            }
            else
            {
                Console.WriteLine("J paye tei lekhchhas gadha!! Hello bhan Hello");
            }

        }
        public string GetText()
        {
            Console.WriteLine("Hello There, Good morning!!");
            string s = Console.ReadLine();
            return s;

        }
        public void GetLargestNumber()
        {
            
            long x = Convert.ToInt64(Console.ReadLine());
            long y = Convert.ToInt64(Console.ReadLine());
            long z = Convert.ToInt64(Console.ReadLine());
            long[] numbers = { x, y, z };
            long max = x;
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];

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
                    break;
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
        public void CheckEvenOrOdd()
        {
            Console.WriteLine("Please Enter Number to check whether it even or odd:");
            long a = Convert.ToInt64(Console.ReadLine());
            string isEven = a % 2 == 0? "The number you Entered is Even" : "The number you Entered is odd";
            Console.WriteLine(isEven);
        }
        public void SumOfNaturalNumbers()
        {
            Console.WriteLine("Enter Number of natural Numbers :");
            int n = Convert.ToInt32(Console.ReadLine());
            int naturalNumber;
            double sum = 0;
            Console.WriteLine("Enter Numbers :");
            for (int i = 0; i < n; i++)
            {
                naturalNumber = Convert.ToInt32(Console.ReadLine());
                sum += Math.Pow(naturalNumber,2);
            }
            Console.WriteLine("The sum of square of "+n.ToString()+" numbers you Entered is : "+ sum.ToString());
        }

    }
}
