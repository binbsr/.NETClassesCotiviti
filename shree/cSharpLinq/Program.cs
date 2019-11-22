using System;
using System.Linq;

namespace cSharpLinq
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            

           /* LINQ is language integrated language
             * 
             * programming language type:
             * 
             * IMPERETIVE  --> it is step by step approach.Like Loop
             * example: */
                
                int[] number = { 2, 3, 4, 5, 6, 7, 8, 9,18,16,20,22 };
            //sum=sum of all array item using loop

            // DECLARATIVE
            //sum = number.Sum();        // here Sum( ) is inbuilt funtion given by Linq language

            //  Way to use LINQ
            //   1.  Query Expressions   --> start with FROM and ends with SELECT

            // get even numbers from number [] 
            var evenNumber = (from num in number
                              where num % 2 == 0 && num < 20 
                              orderby num ascending
                              select num);

          //  2.Method Syntax
                var evenNumber1 = number.Where(num=>num%2==0).Select(x=>x);

            foreach (var n in evenNumber)
            {
                Console.Write(n + " ");
            }

            Console.Write('\n');

            var students=Collections.FetchStudents();

            var a = from student in students
                    where student.CollegeName == "mbm"
                    orderby student.Name ascending
                    select student;

            var stdGroupBy = from std1 in students
                             group std1 by std1.CollegeName into groupStudent
                             where groupStudent.Count()<=2
                             orderby groupStudent.Key
                             select groupStudent;

            /*   var b = from student in students
                       where student.CollegeName == "mbm"
                       select new { student.RollNo, student.CollegeName };     */

            // this will give roll no and college name

            students.Where(stdnt => stdnt.CollegeName == "mbm").Select(x => x.Name);

            //  students.Where(stdnt => stdnt.CollegeName == "mbm").Select(x=>new { x.RollNo, x.CollegeName });

            Console.WriteLine("Roll No    Name");
            foreach (var n in a)
            {
                Console.WriteLine($"{n.RollNo}          {n.Name}");
            }

            Console.WriteLine("\n");
            foreach (var i in stdGroupBy)
            {
                Console.WriteLine($"{i.Key}");
                foreach (var j in i)
                {
                    Console.WriteLine($"\t{j.RollNo}      {j.Name}        {j.CollegeName}");
                }
            }

        }
    }
}
