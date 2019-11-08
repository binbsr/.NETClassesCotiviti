using System;
namespace LoopsAndConditions
{
    public class Conditionals
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello World");

        }
        //Check if user enters "Hi" or "Hello"
        public void CheckIfUserSaysHi()
        {
            Console.WriteLine("Enter greetings..");
            String input = Console.ReadLine();
            if (input == "Hi" || input == "Hello") 
            {
                Console.WriteLine("Wow");
            }            
            else{
                Console.WriteLine("I simply asked you to say Hi but you said "+input+" how rude");
            }
        }

//Largest number among 3 numbers
        public void GetLargest()
        {
            Console.WriteLine("Enter the numbers..");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            int z = Int32.Parse(Console.ReadLine());

            if (x>y && x>z)
            {
                Console.WriteLine(x+" is larger than "+y+" and "+z);
            }
            else if (y>x && y>z)
            {
                Console.WriteLine(y+" is larger than "+x+" and "+z);
            }
            else
            {
                Console.WriteLine(z+" is larger than "+x+" and "+y);
            }

        }

        public void UseTernary()
        {
            int x = 0;
            byte y = 89;
            /*if (y> 90)
                x = 3;
            else
                x = 5;*/
            x = y > 90 ? 3 : 5;    

        }

        //check if entered alphabet is vowel or not
        public void CheckVowel()
        {
            Console.WriteLine("Enter a character...");
            char ch = Convert.ToChar(Console.ReadLine());
            if(char.IsUpper(ch))
            {
                ch=char.ToLower(ch);
            }
            if("aeiou".Contains(ch))
            {
                Console.WriteLine(ch + " is a vowel.");
            }
            else
            {
                Console.WriteLine(ch + " is not vowel.");
            }
            

        }
    }
}