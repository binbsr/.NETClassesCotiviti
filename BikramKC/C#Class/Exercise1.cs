using System;
namespace C_Class
{
    class Excercise1
    {
        byte[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        public void printMultipleOfFive()
        {   
            Console.WriteLine("Multiple of 5:");
            foreach (byte item in a)
            {
                if (item % 5 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
