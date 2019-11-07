using System;

public class CheckString
{

    public void checkHello()
    {
        String name;
        Console.WriteLine("Type here:");
        name = Console.ReadLine();
        if (name == "HelloWorld")
        {
            Console.WriteLine("Hello");
        }
        else
        {
            Console.WriteLine("You have entered wrong string");
        }
    }
    public void getLargest()
    {
        int a, b, c;
        Console.Write("Enter 1st number:");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd number:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 3rd number:");
        c = Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.Write("Greatest is " + a);
        }
        else if (b > c)
        {
            Console.Write("Greatest is " + b);
        }
        else
        {
            Console.Write("Greatest is " + c);
        }
    }

    public void checkVowel()
    {
        Console.Write("Enter Letter ::");
        char[] vowelList = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char letter;
        int count = 0;
        int i = 0;
        letter = Convert.ToChar(Console.ReadLine());
        while (count == 0)
        {
            if (letter == vowelList[i])
            {
                Console.WriteLine("Its a Vowel");
                count++;
            }
            i++;
        }
    }

}



