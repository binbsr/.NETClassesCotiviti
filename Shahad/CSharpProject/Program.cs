using System;
using LoopsAndConditions;
using LearningMethods;
using Constructors;



namespace CSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // UserInput Obj1 = new UserInput();
            // Obj1.test();

            // ConditionExample obj2= new ConditionExample();
            // obj2.PrintHello();

            // CheckString obj3= new CheckString();
            // obj3.checkHello();
            // obj3.getLargest();
            // obj3.checkVowel();

            // EvenOdd obj4 = new EvenOdd();
            // obj4.CheckEven();

            // SumOfSquare obj5 = new SumOfSquare();
            // obj5.printSquares();

            // NestFor obj5 = new NestFor();
            // obj5.NestedLoops();
        
            Methods obj6= new Methods();
            // long sum = obj6.Add2Numbers(11231,21230);
            // Console.WriteLine("Sum is: "+sum);
            // long sum=obj6.Sum(123,123,123,123);
            // Console.WriteLine("Sum is: "+sum);

        //    String Fullname= obj6.GetFullName(Mname:"Chandra",Lname:"Shrestha",Fname:"Shahad"); //Named arguments
        //     Console.WriteLine("Your full name is: "+Fullname);
        
            (int min, int max) result= obj6.GetMinMax(new int[] {2,3,4,5,6,7});
            Console.WriteLine("min is: "+result.min);
            Console.WriteLine("max is: "+result.max);

            PersonInfo person=new PersonInfo("Shahad");
        } 

    }
}
