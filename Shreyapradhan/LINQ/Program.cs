using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] numbers ={2,3,4,5,6,767,89,56};
              var students=Collections.FetchStudents();
            var sum=numbers.Sum();

            //linq --> query expression and Method Syntax --> query expression is preffered
            // query expression - get even numbers
            var evenNumbers= from number in numbers
                            where number%2==0 && number <20
                            orderby numbers ascending
                            select number; //evenNumbers  is query variable

            // Method syntax

            var evenNumbersWitMethodSyntax =numbers.Where(number => number%2==0 && number <20 ).Select(number => number);
           /* foreach (var num in evenNumbers)
            {
                    Console.Write(num+ " ");

            }
            
             foreach (var num in evenNumbersWitMethodSyntax)
            {
                    Console.Write(num+ " ");

            }

           
            var y =from student in students
                where student.CollegeName=="MBM"
                orderby student.Name descending
                select new{student.Name,student.rollNo};

            var x=students.Where(student =>student.CollegeName=="MBM").Select(x=>new{x.Name,x.rollNo});
            Console.WriteLine($"Roll NO.        name");
             foreach (var num in y)
            {
                    Console.WriteLine($"{num.rollNo}        {num.Name}");

            }

            Console.WriteLine("students by college");
            var studentsGroupedByCollege=from student in students
                                         group student by student.CollegeName;

              foreach (var studentgroup in studentsGroupedByCollege)
            {
                    Console.WriteLine($"{studentgroup.Key}");
                    foreach(var stud in studentgroup)
                     {
                          Console.WriteLine($"{stud.rollNo}-{stud.Name}");

                     }

            }*/

            var studentsGroupedByCollegeno=from student in students
                                         group student by student.CollegeName into studentGroup
                                         where studentGroup.Count()<2
                                         orderby studentGroup.Key
                                         select studentGroup;

            foreach (var studentgroup in studentsGroupedByCollegeno)
            {
                    Console.WriteLine($"{studentgroup.Key}");
                    foreach(var stud in studentgroup)
                     {
                          Console.WriteLine($"{stud.rollNo}-{stud.Name}");

                     }

            }

                                         

        
        }
    }
}
