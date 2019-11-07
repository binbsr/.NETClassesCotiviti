using System;

namespace LoopsAndConditions{

    public class Conditionals{

        public void PrintMessage()
        {
            string msg=Console.ReadLine();
            if(msg=="Hello" || msg=="Hi")
             Console.WriteLine("Hello ");
            
            else
             Console.WriteLine("How rude");
        }

         public void PrintHello()
        {
           
             Console.WriteLine("Hello world");
            
        }

        public void GetLargest()
        {
            long x=34234242;
            long y=34234241;
            long z=34234243;

            if(x>y && x>z)
            {
                Console.WriteLine("X is greater"+x);
            }
            else if(y>z)
            {
                Console.WriteLine("Y is greater"+y);
            }
            else 
            Console.WriteLine("Z is greater"+z);
        }

        public void UseTernary()
        {
            int x;
            byte y=89;
            x=y>90 ? 3 : 5;

            Console.WriteLine(x);
             
        }

        public void CheckForVowel()
        {
            char readchar=Convert.ToChar(Console.ReadLine());
            char [] vowels={'a','e','i','o','u'};
            foreach(char x in vowels)
            {
                if(readchar==x)
                Console.WriteLine(x+"is a vowel");
                break;
              
            }

        }

       
    }
}