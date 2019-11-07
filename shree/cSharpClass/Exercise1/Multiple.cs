using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Multiple
    {
        internal void PrintMultiple()
        {
            byte[] numbers= { 1,2,4,5,10,12,13,15,20,30,45,32,68,55,90,65,35,65,12};
            foreach (int val in numbers)
                {
                    if (val % 5 == 0)
                        Console.WriteLine(val);
                }
        }
    }
}
