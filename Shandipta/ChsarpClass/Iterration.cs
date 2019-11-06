using System;
namespace LoopsAndConditions {

    public class Iterration {

        public void DefineLoops () {
            for (int i = 0; i < 100; i++) {
                Console.WriteLine (i);
            }

            int j = 0;
            while (j < 6) {
                Console.WriteLine (j);
                j++;
            }

            int[] nums = { 3, 4, 5, 6, 7, 9 };
            foreach (int num in nums) {
                if (num % 2 == 0)
                    Console.WriteLine (num);
            }
        }
    }

}