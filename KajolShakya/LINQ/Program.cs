using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
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


        }
    }
}
