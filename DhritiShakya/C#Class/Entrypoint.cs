using System;
using System.Collections;
using System.Collections.Generic;
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
            // double average=n.CalculateAverageof3numbers(23,45,76);
            // Console.WriteLine("The average of the numbers is"+ average);
            //  double average1=n.CalculateAverage(new int[] {23,45,67,89,90,54,43,23,55,66});
            //  Console.WriteLine("The average of the numbers is"+ average1);
            // char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            // (int x,int y,int z)total = n.CountGenders(genderCollection);
            // Console.WriteLine($"count of Males {total.x},Count of Females {total.y},Count of Others {total.z}");
            // TestList<string> list=new TestList<string>();//Give the datatype when the object is created,this is generic
            // list.Add("This is string");

            // TestList<byte> list1=new TestList<byte>();
            // list1.Add(23);
            // ArrayList arrayList=new ArrayList();// This is non generic
            // arrayList.Add("sdfsdf");
            // arrayList.Add(23);
            // ArrayList sortedList=new ArrayList();// This is non generic
            // sortedList.Add("sdfsdf");
            // sortedList.Add(23);
            // List<short> list2=new List<short>();
            // list2.Add(23);
            // list2.Add(67);
            // list2.Add(87);
            
            // List<Student> students=new List<Student>();
            // Student std1=new Student()
            // {
            //     name="Dhriti"
            // };//inline initialization
            // Student std2=new Student();
            // {
            //     std2.name="Ravi";
            // }
            // students.Add(std1);
            // students.Add(std2);
            
            // Dictionary<int,string> countries=new Dictionary<int, string>();//dictionary data type-- lets say when I have store postal code and name of a country
            // countries.Add(1,"Nepal");//key should always should be unique,first one is the key 
            // countries.Add(2,"USA");
            // countries.Add(3,"China");
            // countries.Add(4,"Maldives");
            // Console.WriteLine(countries[1]);//here 1 is taken as key so the output is Nepal

            Dictionary<int,string> countries=new Dictionary<int, string>()
            {
                [1]="Nepal",
                [2]="USA",
                [3]="China"
            };
            foreach (var item in countries)
            {
                Console.WriteLine(item.Key + "=" + item.Value);
            }
            
    }
}
}