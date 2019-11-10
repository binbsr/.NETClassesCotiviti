
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
                sum += numbers[i];
            }
            return (sum / (numbers.Length));
        }
        // Wrtie C# method that count total males, females and others, given the array of genders as:
        //char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
        public string GetGender(char?[] gender)
        {
            char male = 'M';
            char female = 'F';
            int m = 0;
            int f = 0;
            int o = 0;
            for (int i = 0; i < gender.Length; i++)
            {
                if (gender[i] == male)
                    m = m + 1;
                else if (gender[i] == female)
                    f = f + 1;
                else
                    o = o + 1;
            }
            string TotalGender = $"{m}, {f} {o}";//string interpolation
            return (TotalGender);
        }
        public (int, int, int) GetGenderTuple(char?[] gender)
        {
            int m = 0;
            int f = 0;
            int o = 0;
            char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            foreach (char?person in genderCollection)
            {
                if (person == 'M')
                    m = m + 1;
                else if (person == 'F')
                    f = f + 1;
                else
                    o = o + 1;
            }
            return (m, f, o);
        }
    }
}
