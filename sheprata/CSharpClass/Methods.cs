using System;
namespace LearningMethods
{
    public class Methods
    {
       public void PrintSomething() //voids returns nothing, public is access modifier, pascal case - firstletter is capital
       {
          Console.WriteLine("Nothing");
       }

       public long AddTwoNumbers(long a, long b) //arguments
       {
           long sum = a + b;
           return sum;
       }

       public long Sum(params long[] numbers) //variable number of arguments
       {
           long sum = 0;
           foreach (long num in numbers)
           {
               sum = sum + num;
           }
           return sum;
       }

       public string GetFullName(string firstName, 
                                 string lastName,
                                 string middleName = "default value")
       {
          string fullName = lastName + ", " + firstName + ", " + middleName; //can be done better using polation
          string fullName1 = $"{lastName},{firstName},{middleName}"; //string interpolation
          return fullName1;
       }

       //Returning multiple values
       public (int,int) GetMinMax(int[] nums)
       {
           int min = nums[0];
           int max = nums[0];
           for(int i = 1; i< nums.Length ; i++)
           {
               if(min > nums[i])
               min = nums[i];
               else
               {
                   max = nums[i];
               }
           }
           return (min,max);  //tuple
       }

// Write C# method that calculate average of 3 decimal number arguments.//
      
       public decimal Average(decimal num1, decimal num2, decimal num3)
       {
           decimal avg = (num1+num2+num3)/3;
           return avg;
       }

// Modify same method above that allows user to supply any number of argumnets and calculate average of all

        public decimal Average(params decimal[] numbers) //any number of arguments
        {
           decimal avg = 0;
           foreach (decimal num in numbers)
           {
               avg = (avg + num);
           }
           avg = avg/2;
           return avg;
       }

  //  Wrtie C# method that count total males, females and others, given the array of genders as:

//char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M',
// null, null, 'F', 'M', 'M' };

public(int,int,int) CountGender()
       {
           char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M',
            null, null, 'F', 'M', 'M' };
        int malecount = 0;
        int femalecount = 0;
        int others = 0;
           foreach(char? gender in genderCollection)
           {
               if(gender == 'M')
               {
                   malecount ++ ;
               }
               else if (gender == 'F')
               {
                   femalecount ++; 
               }
               else
               others ++;
           }
           return (malecount , femalecount ,others);
       }
      

    }
}