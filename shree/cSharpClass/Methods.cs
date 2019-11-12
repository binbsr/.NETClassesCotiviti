using System;
using System.Collections.Generic;
using System.Text;

namespace LearningMethods
{
    public class Methods
    {
        // methods that doesnot returns
        public void PrintSomething()            // access modifier, return type, methods name (method name initial character CAPS
        {
            Console.WriteLine("Nothing");
        }

        public long SumOfTwoNumber(long num1, long num2)
        {
            return (num1 + num2);
        }

        // VARIABLE ARGUMENTS
        public long Sum(params long [] numbers)     //here takes number of argument as a collection

        {
            long sum = 0;
            foreach (long num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // OPTIONAL ARGUMENTS
        public string GetFullName(string fname,  
                                    string lName,
                                    string mName = ""  // this is optional argument that must be on the last
                                    )
        {
            string fullname = $"{lName}, {fname} {mName}";          // this string interpolation  (better approach of string concatenation)
            return fullname;
        }
        //Returning multiple values
        public (int, int) GetMinMax(int[] nums)     // for multiple value return, TUPLE is used as (int, int)
        {
            int min = nums[0];
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (min > nums[i])
                    min = nums[i];
                else
                    max = nums[i];
            }
            return (min, max);
        }
    }
}
