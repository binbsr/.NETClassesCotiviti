using System;
public class SumOfSquare
{   double Sum=0;
    //double j;
    int numberRange;
    public void printSquares()
    {
        Console.WriteLine("Enter the number of natural number: ");
        numberRange = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= numberRange; i++)
        {
            Sum=Sum + Math.Pow(i,2);
        }
        Console.WriteLine(Sum);
    }
}