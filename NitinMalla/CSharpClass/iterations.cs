namespace LoopsAndConditions{
    using System;
    class Iterations
    {
        public void DefineLoops()
        {
            // for loop
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 100)
            {
                Console.WriteLine(j);
                j++;
            }

            int[] nums = {2,4,5,6,7};

            foreach (var num in nums)
            {
                if (num%2 == 0)
                {
                    Console.WriteLine(num);
                }
            }


        }

    }
}
