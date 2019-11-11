using System;

    
namespace LearningMethods
{
    public class Methods
{
    public void PrintSomething()
    {
      Console.WriteLine("Nothing");
    }

    public long AddTwoNumbers(long a,long b)//best practise no more than 5 arguments
    {
       long sum=a+b;
       return sum;
    }

    //Variable number of arguments
    public long Sum(params long[] numbers)
    { 
        long sum=0;
        foreach (long num in numbers)
        {
            sum=sum+num;
        }
        return sum;
    }

    //Optional Arguments
    public string GetFullName(string firstName,
                             string lastName,
                             string middleName="")
    {
        //string fullName= lastName + ","+firstName+" "+ middleName;
        string fullName= $"{lastName}, {firstName} {middleName}";//string interpolation
        return fullName;
    }

    public (int,int) GetMinMax(int[] nums)
    {
        int min=nums[0];
        int max=nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (min>nums[i])
            {
                min=nums[i];
            }
            else 
            max=nums[i];
            
        }
        return (min,max);
    }

    public double CalculateAverageof3numbers(int a,int b,int c)
    {
      double d=(a+b+c)/3;
      return d;
    }

    public double CalculateAverage(int[] nums)
    { 
        double sum=nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            sum=sum+nums[i];
        }
        double avg=sum/nums.Length;
        return avg;
    }

    public (int,int,int) CountGenders(char?[] genders)
    {int countofMales=0;
     int countofFemales=0;
     int others=0;
    foreach (char? gender in genders)
    {   
        if(gender=='M')
        countofMales=countofMales+1;
        else if (gender=='F')
        {
            countofFemales=countofFemales+1;
        }
        else
        {
            others=others+1;
        }
    }
     return (countofMales,countofFemales,others);

    }

    }

}
