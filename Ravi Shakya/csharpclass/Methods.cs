using System;
namespace LearningMethods
{
    public class Methods 
    {
        public void PrintSomething()
        {
         Console.WriteLine("Nothing");
        }
        public long AddTwoNumbers(long a, long b)
        {
            long sum = a+b;
            return sum; 
        }
        public long AddThreeNumbers(long a, long b, long c)
        {
            long sum =a+b+c;
            return sum;
        }
        public long Sum(params long[] numbers)
        {
            long sum = 0;
            foreach (long num in numbers)
            {
                sum =sum + num;
            }
            return sum;
        }
        //Optional Arguments
        public string GetFullName(string firstName, 
                                   string lastName,
                                   string middleName = "")
        {
            string fullName = $"{lastName} ,{firstName}, {middleName}";  //string interpolation
            return fullName;
        }     

        //Returning Multiple Values
        public (int, int) GetMinMax(int[] nums)
        {
           int min = nums[0];
           int max = nums[0];
            for (int i =1; i<nums.Length; i++)
            {
                if(min> nums[i])
                    min = nums[i];
                else
                    max = nums[i];

            }

            return (min, max);
        }                                                 
    }
}