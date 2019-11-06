using System;
namespace Exercise
{
    public class ClassWork
    {
        byte[] array = { 1, 2, 5, 6, 10, 25, 36, 38, 40, 42, 45, 56 };
        public void PrintMultiplesOfFive()
        {
            foreach (var e in array)
                if (e % 5 == 0)
                    Console.WriteLine(e);
    }
    }
}
