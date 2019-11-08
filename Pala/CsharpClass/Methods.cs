
namespace LearningMethods
{
    using System;
    public class Methods
    {
        //DEfine motheds: (accessmodifer,return type,Name)
        public void PrintSomething()
        {
            Console.WriteLine("Nothing");


        }
        public long AddTwoNumbers(long a, long b)//Arguments
        {
            long sum = a + b;
            return sum;
        }
        public long AddThreeNumbers(long a, long b, long c)//Arguments
        {
            long sum = a + b + c;
            return sum;
        }
        //Variable number of arguments
        public long SumMultiple(params long[] numbers)
        {
            long Sum = 0;
            foreach (long num in numbers)
            {
                Sum += num;
            }
            return Sum;
        }
        //Optional Arguments
        public string GetFullName(string firstName, string lastName, string middleName = "")
        {
            string FullName = $"{lastName}, {firstName} {middleName}";//string interpolation
            return FullName;
        }
        //REturning Multiple Values
        public int GetMin(int [] nums)
        {
            int min = nums[0];
            for (int i = 1; i < nums.Length ; i++)
            {
                if(min>nums[i])
                min  = nums[i];
            }
            return min;
        }
        //Get MinMax//use tuple
         public (int,int) GetMinMax(int [] nums)
        {
            int min = nums[0];
            int max = nums[0];
            for (int i = 1; i < nums.Length ; i++)
            {
                if(min>nums[i])
                min  = nums[i];
                else 
                max = nums[i];
            }
            return (min,max);
        }

    }
}
