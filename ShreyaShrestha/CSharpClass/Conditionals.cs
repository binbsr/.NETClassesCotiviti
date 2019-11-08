using System;

namespace LoopsAndConditions
{
    public class Conditionals
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }

        //Read key from user

        public void CheckIfUserSaysHello()
        {
            string input;
            Console.WriteLine("Enter string:");
            input = Console.ReadLine();
            if (input != "Hello")
                Console.WriteLine("You have entered wrong string");
            if (input == "Hi" || input == "Hello")
                Console.WriteLine("Hi");
            Console.WriteLine("The string you have entered is valid : '{0}'", input);
        }

        public void ReturnLargestNumber()
        {
            long x = 12345;
            long y = 4567;
            long z = 67899;
            if (x > y && x > z)
                Console.WriteLine("Largest number is x = '{0}'", x); // "x + "is largest""
            else if (y > z)
                Console.WriteLine("Largest number is y = '{0}'", y);
            else
                Console.WriteLine("Largest is z = '{0}'", z);
        }

        // ternary operator
        public void ImplementTernary()
        {
            int x = 0;
            int y = 89;
            x = y > 90 ? 3 : 5;
        }

        public void CheckVowel()
        {
            string inputChar;
            inputChar = Console.ReadLine();
            bool isVowel = "aeiouAEIOU".IndexOf(inputChar) >= 0;
            if (isVowel)
                Console.WriteLine(inputChar + " is Vowel");
            else
                Console.WriteLine(inputChar + " is not Vowel");
        }


        //Check if entered number is even or not using ternary operator
        public void CheckEvenNumber()
        {
            int value = 0;
            //bool isInt = Int32.TryParse(Console.ReadLine(), out value);
            if (value != 0)
            {
                //bool iseven = value % 2 == 0 ? true : false;
                string iseven = value % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"The number is {value}");
                // if (iseven)
                // {
                //     Console.WriteLine(value + " is even");

                // }

                // else
                // {
                //     Console.WriteLine(value + " is odd");
                // }
            }
        }

        //Calculate the sum of squares of first n natural numbers

        public void CalculateTheSumOfFirstNNaturalNumbers()
        {
            try
            {
                int nNoOfNaturalNumbers = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter numbers:");
                int sum = 0;
                int i = 0;
                int[] inputNumbers = new int[nNoOfNaturalNumbers];
                while (i < nNoOfNaturalNumbers)
                {
                    try
                    {
                        inputNumbers[i] = Int32.Parse(Console.ReadLine());
                        sum += inputNumbers[i] * inputNumbers[i];
                        i++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("The sum of squares of first '{0}' numbers is '{1}'", nNoOfNaturalNumbers, sum);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}