using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsCondition            // namespace is a virtual container
{
    internal class Iteration
    {
        public void DefineLoops()
        {
            // for loop
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while(j<100)
            {
                Console.WriteLine(j);
                j++;
            }

            int[] nums = { 3, 4, 5, 6, 7, 8, 9};
            foreach (int num in nums)                   // shorthand of for loop
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
            }
        }
    }
}
