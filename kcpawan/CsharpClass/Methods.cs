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
            long c = a + b;
            return c;
        }

        // Optional Argument
        public long Sum(params long[] numbers)
        {
            long sum = 0;
            foreach(long num in numbers)
            {
                sum = sum + num;
            }
            return sum;
        }

        //String Interpolation | Variable Argument
        public string GetFullName(string firstName,
                                  string lastName,                                  
                                  string middleName ="")
            {
                string fullName =$"{lastName},{firstName}{middleName}";
                return fullName;
            }

        //Returning multiple values
        public (int,int) GetMinMax(int[] nums)
        {
            int min = nums[0];
            int max = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if(min>nums[i])
                min = nums[i];
                else
                max = nums[i];
            }
            return (min,max);
        }
    }

}