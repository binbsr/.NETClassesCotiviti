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
            bool isVowel=false;
            foreach(char x in vowels)
            {
                if(readchar==x)
                 isVowel=true;
                 break;
                          
            }

            if(isVowel)
              Console.WriteLine("It is a vowel");
            else 
                 Console.WriteLine("It is not a vowel");

        }

        public void CheckOddEvenNumber()
        {
            int number=Convert.ToInt16(Console.ReadLine());
            string iseven=number%2==0?"even":"odd";
            Console.WriteLine(number+" is "+iseven);
            
        }

        public void CalculateSumOfNumber()
        {
             int number=Convert.ToInt16(Console.ReadLine());
             int sum=0;
             
             /*
             int i=0;
             for(int i=1;i<=number;i++)
             {
                    sum+=i*i;
             }
             while(i<=number)
             {
                  sum+=i*i;
                  i++;
             }*/
             sum=(number*(number+1))/2;
          

             Console.WriteLine("Sum of N natural numbers is "+sum);

        }

       
    }
}