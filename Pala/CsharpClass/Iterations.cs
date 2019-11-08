using System;

namespace LoopsAndConditions
{
public class Iterations
{
    public void DefineLoops()
    {
        //for
        for(int i = 0; i < 100; i++) // i is loop variable or iteration variable (initialization, condition statement, increment and decrement)
        {
            Console.WriteLine(i);
        }

        int j = 0;
        while(j < 100) // when exit condition is knwn but the upper bound is unknwn
        {
            Console.WriteLine(j);
            j++;
        }

        int[] nums = {1,2,3,4,5};
        foreach(int e in nums) //to play with index use for otherwise use foreach to play with element
        {
            if(e % 2 ==0)
                Console.WriteLine(e);
        }

        
    }
    public void LearnNestedLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Jai");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Nepal");
                }
            }
            
        }
}
}