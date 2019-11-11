using System;
namespace LearningMethods
{
    public class Methods
    {
        public void PrintSomething()
        {
            Console.WriteLine("Nothing");
        }


        public long AddTwoNumers(long a,long b)
        {
                return a+b;
        }
       // variable number of arguments
        public long Sum(params long[] numbers)
        {
            long sum=0;
            foreach(long number in numbers)
            {
                sum+=number;
            }
             return sum;
        }

        //optional arguements, formal arguments
        public string GetFullName(string firstName,string lastName,string middleName=" ")
        {
              //string interpolation
               string fullname= $"{lastName},{firstName} {middleName}";
               return fullname;
        }

            //returning multiple values
        public (int,int) GetMinMax(int [] nums)
        {
            int min=nums[0];
            int max=nums[0];
            for(int i=1;i<nums.Length;i++)
            {
               if(min>nums[i])
                 min=nums[i];
                else
                {
                    max=nums[i];
                }
            
            }
            return (min,max);
        }

        public decimal CalculateAverage(decimal num1,decimal num2,decimal num3)
        {
            return (num1+num2+num3)/3;
        }

        public decimal CalculateAverageOfAllNumbers(params decimal[] numbers)
        {
            long sum=0;
            foreach(long number in numbers)
            {
                sum+=number;
            }
             return sum/numbers.Length;
        }

        public (int,int,int) ClaculateGenderDistibution()
        {
            int femaleCount=0;
            int maleCount=0;
            int otherCount=0;
            char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            foreach(char?person in genderCollection)
            {

                if(person=='F')
                    femaleCount++;
                else if(person=='M')
                  maleCount++;
                else
                   otherCount++;
                        
            }
            return (femaleCount,maleCount,otherCount);
        }
    }

}