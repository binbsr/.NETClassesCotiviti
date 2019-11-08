using System;
using LearningMethods;
using LoopsAndConditions;

namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()
        {
            Methods m = new Methods(); 
            //Named arguments           
            string name = m.GetFullName(lastName: "Rawal", firstName: "Rawal");
            (int Min, int Max) result = m.GetMinMax(new int[] {4, 3, 5, 2, 6});

            Console.WriteLine($"Minimum = {result.Min} and Largest = {result.Max}");
        }
    }
}
