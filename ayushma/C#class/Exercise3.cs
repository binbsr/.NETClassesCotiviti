using System;
public class Exercise3
{
    public void LearnNestedLoops()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Jai");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Nepal");
            }
        }
    }
    public double AverageofDecimalNumbers(double a, double b, double c)
    {
        double avg = (a + b + c) / 3;
        return avg;
    }
    public long AverageofN(params long[] numbers)
    {
        long sum = 0;
        foreach (long num in numbers)
        {
            sum = sum + num;
        }
        return sum / numbers.Length;
    }
    public void CountGender()
    {
        int male = 0;
        int female = 0;
        int others = 0;
        char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
        foreach (char? gender in genderCollection)
        {
            if (gender == 'M')
            {

                male++;
            }
            else if (gender == 'F')
            {

                female++;
            }
            else
            {

                others++;
            }
        }
        System.Console.WriteLine("M: " + male + " F: " + female + " O: " + others);

    }
}