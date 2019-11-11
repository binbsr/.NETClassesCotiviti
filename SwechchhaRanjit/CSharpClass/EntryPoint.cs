//using LoopandConditions;
using System;
using System.Collections;
using System.Collections.Generic;
using LearningMethods;
using LoopandConditions;
//using MultipleFiveNumbers;
using Practice;

namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()
        {
            /*Iterations iterations = new Iterations();
            iterations.DefineLoops();
            Exercise1 exercise1 = new Exercise1();
            exercise1.Numbers();
            Conditionals h = new Conditionals();
            h.PrintHello();
            Conditionals input = new Conditionals();
            input.InputHello();
            Conditionals largestnm = new Conditionals();
            largestnm.GetLargest();
            
            Conditionals c = new Conditionals();
            c.CheckVowel();
            Conditionals even = new Conditionals();
            even.CheckEvenNm();
            Conditionals sumsq = new Conditionals();
            sumsq.SumSquaresNm();
            
            Methods m = new Methods();
            long s = m.AddTwoNumbers(234234, 234234);
            Console.WriteLine("Sum is " + s);
            long s1 = m.AddThreeNumbers(234234, 234234, 234234);
            Console.WriteLine("Sum is " + s1);
            long s2 = m.Sum(234234,234234,34,34);
            Console.WriteLine("Sum is " + s2);

            //Named Arguments
            string name =m.GetFullName(lastName: "Ranjit", firstName: "Swechchha");
            Console.WriteLine("Name "+ name);

            int min = m.GetMin(new int[] { 4, 3, 5, 2, 6 });
            
            //tuple
            (int min ,int max ) result = m.GetMinMax(new int[] { 4, 3, 5, 2, 6 });
            int m1 = result.min;
            int m2 = result.max;

            Console.WriteLine($"Minimum = (result.min) and Largest = (result.max)"); */

            Exercise2 exercise2 = new Exercise2();
            decimal average = exercise2.CalculateAvgThreeArguments(12.3M, 23.45M, 45.678M);
            Console.WriteLine("The average of given three arguments is: " + average);

            decimal avg = exercise2.CalculateAvgNArguments(new decimal[] { 12.3M, 23.45M, 45.678M });
            Console.WriteLine($"Average of N arguments is: {avg}");

            (int male, int female, int others) result1 = exercise2.CountGenderType();
            Console.WriteLine($"Total count of Males =  {result1.male} , Total count of Females = {result1.female} and Total count of Others = {result1.others}");

            //Non-Generic
            ArrayList arrayList = new ArrayList();
            arrayList.Add("sdf");
            arrayList.Add(345);

            //Generic : used when collections have multiple datatypes 
            /*TestList<string> list = new TestList<string>();
            list.Add("sdfg");

            TestList<byte> list1 = new TestList<byte>();
            list1.Add(34);*/

            List<short> list2 = new List<short>();
            list2.Add(23);
            list2.Add(23);
            list2.Add(23);
            list2.Add(23);

            List<Student> students = new List<Student>();
            Student st1 = new Student { name = "Swechchha" };

            //st1 and st2 creation are same but different ways to represent.
            Student st2 = new Student()
            {
                name = "Ranjit"
            };

            students.Add(st1);
            students.Add(st2);

            //Key must be unique for Dictionary
            Dictionary<int, string> countries = new Dictionary<int, string>();
            countries.Add(1, "USA");
            countries.Add(977, "Nepal");
            countries.Add(91, "India");

            Console.WriteLine(countries[1]);

            foreach (var item in countries)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }

            //countries and countries1 objects are same but different ways to represent.
            Dictionary<int, string> countries1 = new Dictionary<int, string>()

            {
                [1] = "USA",
                [977] = "Nepal",
                [91] = "India"
            };

            Console.WriteLine(countries1[1]);

            foreach (var item in countries1)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
            
        }

    }
}
