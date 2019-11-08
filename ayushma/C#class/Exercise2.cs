using System;
public class Exercise2
{
    public void ConditionalPrint ()
    {
        string name;
        Console.WriteLine ("What is your name?");
        name=Console.ReadLine();
        if (name == "Ayushma")
        {
            Console.WriteLine ("Hello Ayushma");
        }
        else
        {
            Console.WriteLine ("Hello new guy "+ name);
        }
    }
    public void GetLargest ()
    {
        long x = 465789;
        long y = 476890;
        long z = 456890;
        Console.WriteLine ("Print largest");
        if (x>y && x>z)
        {
            Console.WriteLine ("x");
        }
        else if (y>z)
        {
           Console.WriteLine ("y"); 
        }
        else
        {
            Console.WriteLine ("z");
        }
    }
    public void UseTernary()
    {
        int x;
        byte y = 89;
        x = y>90 ? 3:5;
    }
    public void CheckVowel()
    {
    
        Console.Write("Enter Alphabet :");
        char[] vowelList = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char letter;
        letter = Convert.ToChar(Console.ReadLine());
        bool con=false;
        for (int i = 0; i < 9; i++)
        {
            if (letter == vowelList[i])
            {
                Console.WriteLine("Its a Vowel");
                con = true;
            }
        }
        if (!con)
        {
        Console.WriteLine("Its a Consonanat");
        }
    }
    public void UseTernaryEvenOdd()
    {
        int y; 
        Console.WriteLine ("Enter a number:"); 
        y = Convert.ToInt32(Console.ReadLine()); 
        String result = y % 2 == 0 ? "even":"odd";
        Console.WriteLine (result);
        
    }
    public void SumofSquares()
    {
        int n;
        int sum = 0;
        Console.WriteLine ("Enter number of natural numbers");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            sum = sum + (i*i);
        }
        Console.WriteLine(sum);
    }
}