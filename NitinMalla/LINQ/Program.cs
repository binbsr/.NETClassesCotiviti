using System;
using System.Linq;
using System.Collections.Generic;
using LinQ;

class Program
{
    public static void Main(string[] args)
    {
        //Imperative and Declarative
        int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 66, 556, 565 };


        //imperative way of progaramming -- looping
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        // declarative way of programming
        //var sum = numbers.Sum();


        // LINQ -- Query Expression and Method Syntax
        //query Expression
        var evenNumbers = from number in numbers
                          where number % 2 == 0 && number < 20
                          orderby number descending
                          select number;

        // method syntax
        var evenNumbersWithMethodSyntax = numbers.Where(number => number % 2 == 0).Select(x => x);

        foreach (var n in evenNumbers)
        {
            Console.Write(n + " ");
        }

        var students = Collections.GetListOfStudents();

        var y = from student in students
                where student.CollegeName == "MM"
                select student.Name;

        var y1 = from student in students
                 where student.CollegeName == "MM"
                 orderby student.Name ascending
                 select new { student.RollNumber, student.Name };



        var y2 = students.Where(student => student.CollegeName == "MM").Select(x => x.Name);

        var y3 = students.Where(student => student.CollegeName == "MM").Select(x => new { x.RollNumber, x.Name });

        Console.WriteLine($"RollNumber      Name");
        foreach (var n in y1)
        {
            Console.WriteLine($"{n.RollNumber}      {n.Name}");
        }

        var studsGroupedByCollege = from student in students
                                        group student by student.CollegeName into studentsGroup
                                        where studentsGroup.Count() <=2
                                        orderby studentsGroup.Key
                                        select studentsGroup;

        
         Console.WriteLine($"Students by college");
        foreach (var studs in studsGroupedByCollege)
        {
            Console.WriteLine($"{studs.Key}");
            foreach (var stud in studs)
            {
                Console.WriteLine($"\t{stud.Name}");                
            }

        }
                                        








    }
}