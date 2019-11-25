using System;
using System.Linq;
using System.Collections.Generic;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        //public void testing()
        {
            //LINQ: Language Integrated Query
            //Example1
            string[] names = {"Kajol", "Dhriti", "Pawan", "Ayushma", "Shahad"};
            //var orderedNames = names.OrderBy(x => x);
            var namesFiltered = names.Where(x => x.StartsWith("S"));
            foreach(var name in namesFiltered)
            {
                Console.WriteLine(name);
            }

            //Example2
           var students = Collections.FetchStudents();
           var result = from student in students
                        group student by student.CollegeName into studentGroup
                        orderby studentGroup.Key
                        select studentGroup;
            foreach(var x in result)
            {
                System.Console.WriteLine(x.Key);
                foreach(var s in x)
                {
                    System.Console.WriteLine("--" + s.Name);
                }
            }

        //Imperative and declarative

        int[] numbers ={2,3,5,7,2,3,12,34,45,29,86};  

        var sum = numbers.Sum();  //declarative ---most useful in programming style
        var min = numbers.Min();

        //Imperative
        int add = 0;
        foreach (var num in numbers)
        {
            add += num;
        }

        //LINQ - Query Expressions and Method Syntax

        //Query Expression - Get even numbers and their sum
        var evenNumbers = from number in numbers
                            where number %2 ==0 && number<20
                            orderby number ascending
                            select number;

        var evenNumbersLessThan = (from number in numbers
                            where number %2 ==0 && number<20
                            select number);                    

        //Method syntax
        var evenNumbersWithMethodSyntax = numbers.Where(number => number %2 ==0).Select(x => x).Sum();  

        foreach (var n in evenNumbers)
        {
            Console.Write(n + " ");
        }


        //

        var std =Collections.FetchStudents();

        //Filtering and projections

        var y = from student in std //must have
                where student.CollegeName == "Pinnacle" //optional
                orderby student.Name descending //optional
                select new {student.RollNo,student.Name}; //must have

        //Grouping

        var studentsGroupByCollege = from student in std  //must have
                                        group student by student.CollegeName //must have
                                        into studentsGroup //optional
                                        where studentsGroup.Count() <= 2 //optional
                                        orderby studentsGroup.Key//optional
                                        select studentsGroup; //optional

        //std.Where(std => std.CollegeName == "Pinnacle").Select(x => new{x.RollNo, x.Name});

        Console.WriteLine($"Roll No. Name");
        foreach (var n in y)
        {
            Console.WriteLine($"\t {n.RollNo}      {n.Name}");
        }


        Console.WriteLine("Students by college");
        foreach (var studs in studentsGroupByCollege)
        {
            Console.WriteLine($"{studs.Key}");
            foreach (var stu in studs)
            {
                Console.WriteLine($"{stu.RollNo} - {stu.Name}");
            }
        }

        


        }
    }
}
