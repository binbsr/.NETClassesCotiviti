namespace Exercise
{   
    using System;
    public class Exercise1
    {
        public void PrintMultipleOfFive()
        {
            byte[] numbers = {12,10,21,25,10,34,12,50,30,40,36,35,67,76,89,12,38,90,36,32};

            foreach (var n in numbers)
            {
                if (n%5 == 0)
                    Console.WriteLine(n);   
                
            }

        }   
        
    }
}