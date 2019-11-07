using System;
namespace LoopsAndConditions
{

    public class Conditionals
    {


        public void CheckForCorrectString()
        {
            Console.WriteLine("Please say Gracious!!");
            String str = Console.ReadLine();
            if (str == "Gracious")
            {
                Console.WriteLine("Wow you said " + str + ". " + "Thank you!");
            }
            else
            {
                Console.WriteLine("I simply asked you to say Gracious but you said " + str + " how rude.");
            }

        }

        public void GetLargestNumber()
        {
            Console.WriteLine("Enter your 1st number");
            int x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter your 2nd number");
            int y = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter your 3rd number");
            int z = Convert.ToInt32(Console.ReadLine());
            if (x > y && x > z)
            {
                Console.WriteLine(x + " is greater than " + y + " and " + z);
            }
            else if (y > x && y > z)
            {
                Console.WriteLine(y + " is greater than " + x + " and " + z);

            }
            else Console.WriteLine(z + " is greater than " + x + " and " + y);


        }

        public void UseTernary()
        {
            int x, y = 89;
            /* if(y>90)
             x=3;
             else
             x=5;
             */
            x = y > 90 ? 2 : 5;
            Console.WriteLine(x);

        }

        public void CheckVowel()
        {

            Console.WriteLine("Enter a Character......");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            if ("aeiou".Contains(ch))
            {
                Console.WriteLine(ch + " is a vowel");
            }
            else Console.WriteLine(ch + " is not a vowel");


        }


    }



}