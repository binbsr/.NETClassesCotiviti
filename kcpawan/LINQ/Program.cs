using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ : Language Integrate Query
            //Example 1

            string[] names = {"Bishnu","Pala","Shreya","Bikram","Pawan","Sheela","Pravinda"};
           // var orderednames = names.OrderByDescending(x => x);
           var namesFiltered = names.Where(x=>x.StartsWith("S")) ;
            foreach (var name in namesFiltered)
            {
                Console.WriteLine(name);
            }

            //Example 2

           var  students = Collections.FetchStudents();

           var result = from student in students
                       // where student.address == "Imadole"
                        group student by student.address into studentGroup
                        //orderby students.Key
                        select studentGroup;
            
            foreach (var x in result)
            {
                System.Console.WriteLine(x.Key);
                foreach(var s in x)
                {
                    System.Console.WriteLine("--"+s.name);
                }
            }
        }
    }
}
