using System;

namespace LoopsAndConditions
{

public class Iterations
{
    public void DefineLoops()
    {
        for (int i = 0; i<100; i++)
        {
            //Console.WriteLine(i);
        }
        int j = 0;
        while (j < 100)
        {
            //Console.WriteLine(j);
            j++;
        }
        int[] nums = {3, 4, 5, 6, 7, 9};
        foreach (int num in nums)
        {
            if(num % 2 ==0 )
            Console.WriteLine(num);
        }

    
    }
    public void LearnNestedLoops()
    {
        for (int j =0; j <5; j++)
        { 
            Console.WriteLine("Jai");
            for (int k=0; k<10; k++)
            {
                Console.WriteLine("Nepal");
            }
        }
    }
}
}
