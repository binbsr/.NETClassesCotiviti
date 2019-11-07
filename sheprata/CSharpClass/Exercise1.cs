using System;
public class Exercise1{
     static void Main(){
    Multipleof5();
    }

    internal static void Multipleof5()
    {
        byte[] array1 = new byte[6] {2,3,4,5,6,7};
         foreach (byte num in array1)  //for every item in array when we don't need idex;if index needed go 4 for
     {
           if (num % 5 == 0)
             Console.WriteLine(num);
     }

    }
    
}