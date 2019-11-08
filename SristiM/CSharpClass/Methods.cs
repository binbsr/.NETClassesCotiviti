using System;

namespace LearningMethods
{
    public class Methods//access modifiers: public,private,protected
    {
        public void PrintSomething() //Void is return type, and method  name has to be pascal case
        {
            Console.WriteLine("Nothing");
        }

        public long AddTwoNumbers(long a, long b)//arguments can be any number of variables, best practice no more than 5
        {
            long sum = a + b;
            return sum;
        }

        public long Sum(params long[] numbers)//variable number of arguments
        {
            long sum = 0;
            foreach (long num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public string GetFullName(string firstName,
                                 string lastName,//variables in camel case
                                 string middleName = "")//define optional argument with default value,should be at the end)
        {
            //string fullName = lastName + ", " + firstName + " " + middleName;
            string fullName = $"{lastName}, {firstName} {middleName}";//string interpolations
            return fullName;
        }


        //Returning Multiple values from a method
        public (int, int) GetMinMax(int[] nums)
        {
            int min = nums[0];
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
                else
                {
                    max = nums[i];
                }

            }
            return (min, max);
        }

    }
}
