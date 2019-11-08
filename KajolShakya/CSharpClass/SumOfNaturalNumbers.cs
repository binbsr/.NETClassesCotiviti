using System;
namespace LoopsAndConditions
{
    public class SumOfNaturalNumbers
    {
        //Sum of Squares of first n natural numbers.
        public void NaturalNumbersSum()
        {
            int num;
            int sum;
            Console.WriteLine("Enter a number...");
            num = Convert.ToInt32(Console.ReadLine());
            sum = (num*(num+1)/2);
            Console.WriteLine("The sum of first "+num+" natural numbers is "+sum);
        }
    }
}