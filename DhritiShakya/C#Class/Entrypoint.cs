using System;
using LearningMethods;
using LoopsAndConditions;
namespace MainProgram
{

public class EntryPoint
{
    public static void Main()
    {
        Multiple m =new Multiple();
       Conditionals c=new Conditionals();
       Iterations o=new Iterations();
      Methods n=new Methods();

            //    c.GetLargest();
            //    c.CheckTheVowel();
            //    c.CheckIfUserSaysHello();
            //    c.CheckEven();
            //    c.CalculateSumOfSquares();
            //    m.CheckMultiple();
            // o.LearnNestedLoops();
            //   long s=n.AddTwoNumbers(6675656,6675675);
            //   Console.WriteLine("The sum is"+ s);
            //    string name= n.GetFullName(lastName:"Dhriti",firstName:"Shakya");
            //    Console.WriteLine("My name is"+ name);
            //   (int Min,int Max) result= n.GetMinMax(new int[] {4,5,6,7,8});
            //   Console.WriteLine("The min number is"+ result.Min);
            //   Console.WriteLine("The max number is"+ result.Max);
            //    Console.WriteLine( $"The max number is {result.Min},The max number is {result.Max}");
            double average=n.CalculateAverageof3numbers(23,45,76);
            Console.WriteLine("The average of the numbers is"+ average);
             double average1=n.CalculateAverage(new int[] {23,45,67,89,90,54,43,23,55,66});
             Console.WriteLine("The average of the numbers is"+ average1);
            char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            (int x,int y,int z)total = n.CountGenders(genderCollection);
            Console.WriteLine($"count of Males {total.x},Count of Females {total.y},Count of Others {total.z}");

    }
}
}