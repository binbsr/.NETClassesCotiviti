using System;
namespace LoopsAndConditions
{
    //Check if entered number is even or not (use Ternary Operator)

    public class CheckForEvenNumbers
    {
       public void CheckForEvenNumber()
       {
           int num;
            Console.WriteLine("Enter a number to check if its even or not..");
            num = Convert.ToInt32(Console.ReadLine());
            String result = (num%2==0)?"Even":"Odd";
            Console.WriteLine(num+" is "+result);
            
       } 
    }

}