using System;
    namespace LoopsAndConditions{
    public class Iterations
    {
        public void DefineLoops()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

            }

            //When we dont know the upperbound then use while or do-while

            int j = 0;
            while (j < 100)
            {
                Console.WriteLine(j);
                j++;
            }

            int[] nums = { 3, 4, 5, 6, 7, 8, 9 };
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
            }


        }
        public void LearnNestedLoops()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Jay");
                
                for(int j=0; j < 10; j++)
                {
                    Console.WriteLine("Nepal");
                }
            }
        }
    }
}