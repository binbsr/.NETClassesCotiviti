using System;

namespace LoopsAndConditions
{
    public class Iterations
{
     public void DefineLoops()
     {
         for (int i=0;i<100;i++)
         {
             Console.Write(i);
         }
          
        int j=0;
         while (j<100)
         {
             Console.Write(j);
             j++;
         }

         int[] marks={1,2,3,4,5};

         foreach(int x in marks)// if index is not important use for --> compiler uses for loop for for each
         {
             if(x%2==0)
                Console.WriteLine(x);
         }


     }

     public void LearnNestedLoops()
     {
         for(int i=0;i<5;i++)
         { 
                Console.WriteLine("Jai");
                for(int j=0;j<10;j++)
                {
                    Console.WriteLine("Nepal");
                }
         }
     }

}
}