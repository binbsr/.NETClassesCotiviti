using LoopsAndConditions;
using System;

public class NestFor
{
    public void NestedLoops()
    {

        for (int i = 0; i <= 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
                
            }
            Console.WriteLine(" ");
        }
    }
}