using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ {
    class Program {
        static void Main (string[] args) {
            //LINQ-Language Integrated Query
            //Example-1
            string[] names = { "Sristi", "Ayushma", "Shreya" };
            var orderedNames = names.OrderBy (x => x); //lamda expression, arrow operation, x (individual item)goes to x as there is one parameter 
            var namesFiltered = names.Where (x => x.StartsWith ("S")); //filter name starting with S

            // foreach (var name in namesFiltered) {
            //     Console.WriteLine (name);

            // }

            //Example-2
            // var students = Collections.FetchStudent ();
            // var result = from student in students
            // //where students.CollgeName="KU"
            // group student by student.CollegeName into studentGroup
            // orderby studentGroup.Key
            // select studentGroup;

            // foreach (var x in result) {
            //     //System.Console.WriteLine (x.Key);
            //     foreach (var s in x) {
            //         System.Console.WriteLine (x.Key + "--" + s.Name);

            //     }
            //}
            //------------------------------------Nov-22 class--------------------------------------------------
            int[] numbers = { 18, 2, 3, 4, 5, 6, 7, 8, 99, 104 };

            //Declarative
            var sum = numbers.Sum ();

            //Imperative
            int sum1 = 0;
            foreach (var num in numbers) {
                sum1 += num;
            }

        Console.WriteLine($"The sum of listed integers is {sum1}");

            //Linq -  Query Expressions and method syntax
            var evenNumber = from number in numbers
            where number % 2 == 0 && number < 20
            orderby number ascending
            select number;

            foreach (var n in evenNumber) {
                Console.WriteLine (n);
            }

            //Method syntax
            //  Console.WriteLine ("The even numbers less than 20 are");
            // var evenNumbersWithMethodSyntax = numbers.Where (numbers => numbers % 2 == 0).Select (x => x);
            

            //   foreach (var n in evenNumbersWithMethodSyntax) {
            //     Console.WriteLine (n);
            // }
                  Console.WriteLine ();

            // extract the student details from college TU
            var students = Collections.FetchStudent ();
            var y = from student in students
            where student.CollegeName == "KU"
            orderby student.Name descending
            //select student.Name;
            select new { student.RollNo, student.Name }; //anonymous type

            Console.WriteLine ($"Roll No.  Name");
            foreach (var n in y) {
                Console.WriteLine ($"{n.RollNo}        {n.Name}");
            }

            
            //Using method syntax for the same i.e. to extract the student details from college TU
            // Console.WriteLine();
            // Console.WriteLine ("Student from college TU using Method");            
            // var methodStudents=students.Where (student => student.CollegeName == "TU").Select (x => x.Name);
            //  foreach (var n in methodStudents) {
            //     Console.WriteLine ($" {n}");
            // }
            // Console.WriteLine();

           

            //Using group by
            var studentGroupedByCollege = from student in students
            group student by student.CollegeName into studentsGroup
            where studentsGroup.Count () <= 2
            orderby studentsGroup.Key
            select studentsGroup;

            foreach (var studs in studentGroupedByCollege) //studs is itself collection of students
            {
                Console.WriteLine ($" Collge with less than 2 student -{studs.Key} have given list of students:");
                foreach (var stud in studs) {
                    Console.WriteLine ($"\t{stud.RollNo} - {stud.Name}");
                }

            }

            //----------------------------------------------------------------------------
        }
    }
}