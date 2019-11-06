using System;
namespace Exercise{


public class ClassWork
{
    byte[] knownNumbers={1,2,3,4,5,10,25,15,35,24,20,22,13,23,45,11,22,34,36,80,90};

    public void CalculateMultipleOfFive()
    {
        foreach(byte x in knownNumbers)
      {
        if(x%5==0)
        {
            Console.WriteLine(x);
        }
      }
    }
   
 }
}