using System;
namespace Excercise
{
    public class Excercise1
    {
        public void PrintMultipleOfFive()
        {

            int[] nums = { 3, 4, 5, 6, 7, 8, 9, 10, 15, 18, 19, 20, 25, 100, 30, 31, 100, 96, 99, 92, 105, 120, 101 };
            foreach (int num in nums)
            {
                if (num % 5 == 0)
                    Console.WriteLine(num);
            }


        }
    }
}