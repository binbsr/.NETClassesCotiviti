using System;

namespace LoopsAndConditions 
{
    //Assignment Day 4: 7th November, 2019
    public class Assignments
    {
        public void CheckEvenOrOdd()
        {   
            int i;
            Console.WriteLine ("Enter an Even Integer: ");
            i = int.Parse(Console.ReadLine());
            bool isEven;
            isEven = i % 2 ==0 ? true: false;
            Console.WriteLine (isEven);
            
        }

        public void SumOfSquares()
        {
            int i, n, sum = 0;
            Console.Write("\n\n");
            Console.Write("Enter the no of terms : ");
            
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                Console.Write("{0} ", i*i);
                sum+=i*i;
            }
            Console.Write("\n The Sum of Square of Natural Number upto {0} terms = {1} \n",n,sum);

            
        }
    }
}
