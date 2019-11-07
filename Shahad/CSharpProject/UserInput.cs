using System;

public class UserInput
{
    public void test()
    {
        int num;
        int j = 0;
        Console.Write("Enter a number - ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int k = 5; j < num; k = k + 5)
        {
            System.Console.Write(k + " ");
            j++;
        }
    }

}
