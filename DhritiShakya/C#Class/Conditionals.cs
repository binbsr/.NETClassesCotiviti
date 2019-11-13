using System;

namespace LoopsAndConditions
{
    public class Conditionals
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello World");
        }

        public void CheckIfUserSaysHello()
        {
            string userdata;
            userdata=Console.ReadLine();
            if (userdata=="Hello")// we can have multiple conditions in one if statement either OR || or AND
            {
                Console.WriteLine("This is expected input");
            }
            else if (userdata=="Hi")
            {
                Console.WriteLine("This is expected input");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }

        public void GetLargest()
        {
            long x=5454354;
            long y=5456546;
            long z=5656566;
            if (x>y && x>z)
            {
                Console.WriteLine(x +"is the greatest number");
            }
            else if (y>z)
            {
                Console.WriteLine(y +"is the greatest number");
            }
            else
            {
              Console.WriteLine("z is the greatest number");
    
            }
        }

        public void UseTernary()
        {
            int x;
            int y=89;
            x = y> 90 ? 3:5;//Can be used to avoid the if else conditions
        }

        public void CheckTheVowel()
        {
           string Enterdata =Console.ReadLine();
            
            if (Enterdata=="a" || Enterdata=="e" || Enterdata=="i" || Enterdata=="o" ||Enterdata=="u")
            {
              Console.WriteLine("The entered data is a vowel"); 
            }
            else
            {
                Console.WriteLine("The entered data is a consonant");
            }
        }

        public void CheckEven()
        {
            string a=Console.ReadLine();
            int b=int.Parse(a);
            Console.WriteLine((b%2==0) ? b+"  is even" : b+"  is odd");

        }

        public void CalculateSumOfSquares()
        {
            double sum=0;
            for (int i = 1; i <=10; i++)
            {

              sum = sum + Math.Pow(i, 2);
                
            }
            Console.WriteLine("The sum of the squares is"+ sum);
        }
    }
}