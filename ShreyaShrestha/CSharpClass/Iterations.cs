using System;

namespace LoopsAndConditions
{
    public class Iterations
    {
        public void DefineLoops()
        {
            //for
            for (int i = 0; i < 100; i++) // i is loop variable or iteration variable (initialization, condition statement, increment and decrement)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 100) // when exit condition is knwn but the upper bound is unknwn
            {
                Console.WriteLine(j);
                j++;
            }

            int[] nums = { 1, 2, 3, 4, 5 };
            foreach (int e in nums) //to play with index use for otherwise use foreach to play with element
            {
                if (e % 2 == 0)
                    Console.WriteLine(e);
            }
        }

        // 8th Nov

        public void LearnNestedLoops()
        {
            // for (;i < 5;) is also allowed
            for (int i = 0; i < 5; i++) // for(int i=0, int j = 0; i< 5 , j < 10; i++, j++) multiple conditions are valid
            {
                Console.WriteLine("Jay");
                for(int j = 0 ; j < 10 ; j++)
                {
                    Console.WriteLine("Nepal");
                }
            }
    }
    }
}