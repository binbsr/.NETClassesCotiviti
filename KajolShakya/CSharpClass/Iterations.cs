using System;

namespace LoopsAndConditions {

    public class Iterations {
        public void DefineLoops () {
            for (int i = 0; i < 100; i++) {
                Console.WriteLine (i);
            }

            int j = 0;
            while (j < 100) {
                Console.WriteLine (j);
                j++;
            }

            int[] nums = { 3, 4, 5, 6, 7, 9 };
            foreach (int num in nums) {
                if (num % 2 == 0)
                    Console.WriteLine (num);
            }
        }


        public void LearnNestedLoops()
        {
           /* 
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Jai");
                for (int j = 0; j< 10; j++)
                {
                    Console.WriteLine("Nepal");
                }
            } */

            int i = 0;
            for (; i<5;)   //For loop act as while loop
            {
                Console.WriteLine("Jai");
                i++;
            }
        }

    }
}