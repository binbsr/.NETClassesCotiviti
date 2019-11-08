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
    }

}