using System;
public class EvenOdd
{
public void checkEven()
    {   String result;
        int number;
        Console.WriteLine("Enter number to check Even/Odd :");
        number = Convert.ToInt32(Console.ReadLine());
        result= number % 2 == 0?"Even":"Odd";
    
            Console.WriteLine("Result is "+ result);

    }
}
