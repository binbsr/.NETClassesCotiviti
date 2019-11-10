using System;
namespace LearningMethods
{
    public class Methods
    {
       public void PrintSomething() //voids returns nothing, public is access modifier, pascal case - firstletter is capital
       {
          Console.WriteLine("Nothing");
       }

       public long AddTwoNumbers(long a, long b) //arguments
       {
           long sum = a + b;
           return sum;
       }

       public long Sum(params long[] numbers) //variable number of arguments
       {
           long sum = 0;
           foreach (long num in numbers)
           {
               sum = sum + num;
           }
           return sum;
       }

       public string GetFullName(string firstName, 
                                 string lastName,
                                 string middleName = "default value")
       {
          string fullName = lastName + ", " + firstName + ", " + middleName; //can be done better using polation
          string fullName1 = $"{lastName},{firstName},{middleName}"; //string interpolation
          return fullName1;
       }

       //Returning multiple values
       public (int,int) GetMinMax(int[] nums)
       {
           int min = nums[0];
           int max = nums[0];
           for(int i = 1; i< nums.Length ; i++)
           {
               if(min > nums[i])
               min = nums[i];
               else
               {
                   max = nums[i];
               }
           }
           return (min,max);  //tuple
       }

    }
}