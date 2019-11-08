using System;

namespace LearningMethods
{
    public class Methods
    {
        public void PrintSomething()
        {
            Console.WriteLine("Nothing");
        }

        public long AddThreeNumbers(long a, long b, long c)
        {
            long sum = a + b + c;
            return sum;
        }

        //Variable number of arguments
        public long sum (params long [] numbers)
        {
            long sum = 0;
            foreach (long num in numbers)
            {
                //sum += num;
                sum = sum + num;
            }
            return sum;
        }

        //Optional Arguments

        public string GetFullName(string firstName,
                                    string lastName ,
                                    string middleName = "")
        {
           // string fullName = lastName + ", " + firstName + " " + middleName; 
            string fullName = $"{lastName}, {firstName} {middleName}"; 
            return fullName;
        }

        //Returning multiple values

        public (int, int) GetMinMax(int[] nums)
        {
            int min = nums[0];
            int max = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
                else
                    max = nums[i];

            }
            return (min, max);
        }

        //Calculate average of 3 decimal number arguments.

        public decimal AverageThreeArguments(decimal a, decimal b, decimal c)
        {
            decimal sum = a+b+c;
            decimal avg = (sum/3);
            return avg;
        }

        //modify same method above that allows user to supply any number of arguments and calculate average of all.

        public decimal AverageNArguments(params decimal[] numbers)
        {
            decimal average,sum=0;
            int totalArguments=numbers.Length;
            foreach(decimal n in numbers){
                sum=sum+n;
            } 
            return average=sum/totalArguments;
        }

        //method that count total males, females and others, given the array of genders as:
        //char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };

        public (int,int,int) GetGender()
        {
            char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            int male = 0, female = 0, others = 0;
            foreach(char? n in genderCollection)
            {
                if(n=='F')
                {
                    female++;
                }
                else if(n=='M')
                {
                    male++;
                }
                else
                others++;
            }
            return(male,female,others);
            
        }
    }
}