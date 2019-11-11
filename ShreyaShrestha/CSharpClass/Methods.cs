using System;

namespace LearnNewMethods
{
    public class Methods
    {
        //Methods that returns nothing
        public void Print()
        {
            Console.WriteLine("nothing");
        }

        //Argument methods that returns value
        public long ReturnSum(long a, long b)
        {
            return (a + b);
        }

        //Variable number of arguments while invoking the method, data type must be same

        public long Sum(params long[] numbers)
        {
            long sum = 0;
            foreach (long num in numbers)
                sum += num;
            return sum;
        }

        //optional arguments
        public string GetFullName(string firstName, string lastName, string middleName = "")
        {
            string fullName = $"{lastName}, {firstName} {middleName}";
            return fullName;
        }

        //Tuples : Returning multiple values
        public (int, int) GetMinAndMax(int[] nums)
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

        //Calculate average of Three Decimal numbers
        public decimal GetAverageOfThreeDecimalNumber(decimal a, decimal b, decimal c)
        {
            return (a + b + c) / 3;
        }

        //Modify same method above that allows user to supply any number of argumnets and calculate average of all.

        public decimal GetAverageOfNDecimalNumbers(decimal[] nums)
        {
            decimal sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }

        //Wrtie C# method that count total males, females and others, given the array of genders as:

        //char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
        public (int, int, int) GetGenderCount()
        {
            int femaleCount = 0 ;
            int maleCount = 0 ;
            int nullCount = 0 ;
            char?[] gender = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            foreach(char? e in gender)
            {
                if(e == 'F')       
                {
                    femaleCount++;
                }  

                else if(e == 'M')
                {
                    maleCount++;
                }  

                else
                {
                    nullCount++;
                }
            }
            return(femaleCount,maleCount,nullCount);            
        }
    }
}
