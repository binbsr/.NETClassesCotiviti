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


    }


}