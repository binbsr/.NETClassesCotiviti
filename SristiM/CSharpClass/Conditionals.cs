using System;
namespace LoopsAndConditions
{
    public class Conditionals
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }

        public void CheckIfUserSaysHi()//start with caps and verb
        {
            string UserInputStore;
            Console.WriteLine("Can you say Hi or Hello?");
            UserInputStore = Console.ReadLine();
            if (UserInputStore == "Hi" || UserInputStore == "Hello")
            {
                Console.WriteLine("Valid String!");

            }
            else
            {
                Console.WriteLine("You did not say Hi or Hello");
            }
        }

        public void GetLargest()
        {
            long x = 787;
            long y = 8999;
            long z = 9;


            if (x > y && x > z)
            {
                Console.WriteLine(x + " is the largest");
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

        public void UseTennary()
        {
            int x = 0;
            byte y = 80;
            x = y > 90 ? 3 : 5;
        }

        public void CheckVowels()
        {
            Console.WriteLine("Please enter a vowel letter");
            char[] vowelList = { 'a', 'e', 'i', 'o', 'u' };
            char inputletter = Convert.ToChar(Console.ReadLine());
            /*  if (inputletter == "a" || inputletter == "e" || inputletter == "i" || inputletter == "o" || inputletter == "u")
              {
                  Console.Write("You entered vowel letter " + inputletter);
              }
              else
              {
                  Console.WriteLine("You did not enter vowel letter ");
              }
               */
            //char lowerCaseVowel=char.ToLower(inputletter);
            foreach (char vowel in vowelList)
            {
                if (vowel == inputletter)
                { Console.Write("You entered vowel letter " + inputletter); }
                else
                {
                    Console.WriteLine("You did not enter vowel letter ");
                }
            }
        }

        public void EvenNumberCheckTernary()
        {
            Console.WriteLine("Please enter any whole number");
            int x = Convert.ToInt16(Console.ReadLine());
            string evenOrNot;

            evenOrNot = (x % 2 == 0) ? "Even" : "Odd";

            Console.WriteLine("The number you entered is " + evenOrNot);
        }

        public void SumofSquares()
        {
            int n;
            int sum = 0;
            Console.WriteLine("Enter number of natural numbers");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = sum + (i * i);
            }
            Console.WriteLine(sum);
        }

        public void LearnNestedLoops()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Jai");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Nepal");
                    
                }
                
            }
        }
    }




}


