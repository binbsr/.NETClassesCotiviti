using System;
namespace DotNetClass
{
    class Iterations
    {
        public void DefineLoops()
        {
            Console.WriteLine("For Loop starts here:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            int j = 0;
            Console.WriteLine("While starts here:");
            while (j < 6)
            {
                Console.WriteLine(j);
                j++;
            }
            int[] nums = { 3, 4, 5, 6, 7, 9 };
            Console.WriteLine("Foreeach loop starts here:");

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
            }
        }
    }
}
