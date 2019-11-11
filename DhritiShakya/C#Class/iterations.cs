 namespace LoopsAndConditions
 {
 
 using System;
 
 class Iterations
{
 
    public void Defineloop()

    {
        for (int i = 0; i < 100; i++) // i is the iteration varariable,i<length is condition and i++ is iteration
        {
            Console.WriteLine(i);
        }
        
        int j=0;
        while (j<100)
        {
           Console.WriteLine(j);
           j++;
        }

        int[] nums={2,3,4,6,7,9};
        foreach (int num in nums)
        {
            if(num % 2==0)
            Console.WriteLine(num);
        }
    }
    public void LearnNestedLoops()
    {
        for (int i = 0;i <5 ;i++)
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