using System;
 namespace MultipleFiveNumbers
 {
 public class Exercise1
    {
        byte[] MultipleFive = { 5, 6, 10, 15, 22, 25, 34, 35, 36, 40, 41, 42, 44, 45, 46, 47, 48, 49, 50, 55};
        public void Numbers()
        {   
            foreach (int num in MultipleFive )
            {
                if (num % 5 == 0)
                    Console.WriteLine("Multiple of 5 are : "+ num);
            }
        }
    }
 }
