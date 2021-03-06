﻿using System;
using System.Linq;
using System.Collections.Generic;
using EFGetStarted;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // //LINQ: Language Integrated Query

            // int[] numbers = { 8, 4, 2, 3, 5, 7, 2, 3, 12, 34, 45, 29, 86 };

            // //Declariative
            // var sum = numbers.Sum();

            // //Imperative
            // int sum1 = 0;
            // foreach (var num in numbers)
            // {
            //     sum1 += num;
            // }

            // //LINQ - Query Expressions and Method Syntax

            // //Query Expression - Get even numbers
            // var evenNumbers = from number in numbers
            //                   where number % 2 == 0 && number < 20
            //                   orderby number ascending
            //                   select number;

            // //Method syntax
            // var evenNumbersWithMethodSyntax = numbers.Where(number => number % 2 == 0).Select(x => x);

            // // foreach (var n in evenNumbers)
            // // {
            // //     Console.Write(n + " ");
            // // }

            // var students = Collections.FetchStudents();

            // //Filtering and projections
            // var y = from student in students //Must have
            //         where student.CollegeName == "MBM" //Optional
            //         orderby student.Name descending  //Optional
            //         select new { student.RollNo, student.Name }; //Must have

            // //Grouping
            // var studentsGroupedByCollege = from student in students //Must have
            //                                group student by student.CollegeName //Must have
            //                                into studentsGroup //Optional
            //                                where studentsGroup.Count() <= 2 //Optional
            //                                orderby studentsGroup.Key //Optional
            //                                select studentsGroup; //Optional

            // // Console.WriteLine($"RollNo.    Name");
            // // foreach (var n in y)
            // // {
            // //     Console.WriteLine($"{n.RollNo}      {n.Name}");
            // // }

            // // Console.WriteLine("Students by college");
            // // foreach (var studs in studentsGroupedByCollege)
            // // {
            // //     Console.WriteLine($"{studs.Key}");
            // //     foreach (var stud in studs)
            // //     {
            // //         Console.WriteLine($"\t{stud.RollNo} - {stud.Name}");
            // //     }
            // // }

            // //Joining
            // var faculties = Collections.FetchFaculties();
            // var depStudents = from student in students
            //                   join faculty in faculties on student.FacultyId equals faculty.Id
            //                   select new { Department = faculty.FacultyName, Student = student };

            // var depStudentsGroupedByFacultyId = from x in depStudents
            //                                     group x by x.Department;
            // foreach (var item in depStudentsGroupedByFacultyId)
            // {
            //     Console.WriteLine($"{item.Key}");
            //     foreach (var s in item)
            //     {
            //         Console.WriteLine($"\t{s.Student.RollNo} - {s.Student.Name}");
            //     }
            // }

            using (var db = new BloggingContext())
            {
                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                db.SaveChanges();

                // Delete
                // Console.WriteLine("Delete the blog");
                // db.Remove(blog);
                // db.SaveChanges();
            }
        }
    }
}