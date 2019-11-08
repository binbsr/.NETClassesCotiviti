
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
        public int GetMin(int[] nums)
        {
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (min > nums[i])
                    min = nums[i];
            }
            return min;
        }
        //Get MinMax//use tuple
        public (int, int) GetMinMax(int[] nums)
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
        // Write C# method that calculate average of 3 decimal number arguments of 3 decimal number 
        public float AvgDec(float num1, float num2, float num3)
        {
            float Avg = (num1 + num2 + num3) / 3;
            return Avg;
        }
        //Modify same method above that allows user to supply any number of argumnets and calculate average of all.
        public float AvgAll(params float[] numbers)//declaring any number of arguments
        {
            //Console.WriteLine("length is =" + numbers.Length);
            float sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                 sum+=numbers[i];
            }
            return(sum/(numbers.Length));
        }

    }
}
