using System;

namespace LoopsAndConditions 
{
    public class Conditionals
    {
        public void PrintHello()
        {
            Console.WriteLine ("Hello World");
        }

        public void CheckInput()
        {
            String Input;
            Input = Console.ReadLine ();
            if (Input == "Hi")
            {
                Console.WriteLine ("Hello World, you have entered the correct input");
            }
            else
            {
                Console.WriteLine ("Sorry, you have entered incorrect input");
            }


        }
        public void GetLargest()
        {
            long x = 34234242;
            long y = 34523523;
            long z = 34698874;
            if (x>y && x>z)
            {
                Console.WriteLine ("X is the Greatest Number");
            }
            else if (y>z)
            {
                Console.WriteLine ("Y is the Greatest Number");
            }
            else
            {
                Console.WriteLine ("Z is the Greatest Number");
            }
        }

        public void UseTernnary()
        {
            int x = 0;
            byte y = 89;
            
            x = y >90 ? 3: 5;


        }
        public void CheckIfVowel()
        {
            Char ch;
            Console.WriteLine("Input an Alphabet (A-Z or a-z): ");
                       
            ch = Convert.ToChar (Console.ReadLine());
           
           if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine ("The entered character is a vowel");
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine ("The entered character is a Consonent");
            }
        }
        
    }

}