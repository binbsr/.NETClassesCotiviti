using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ language intregated  Query
            //Example
            string[] names = { "Bishnu", "Pawan", "Shristi", "pala" };
            //var orderedNames = names.OrderBy(x => x);//Lamda expression order by 
            var namesFiltered = names.Where(x=>x.StartsWith("S"));//method systax to use linq
            foreach (var name in namesFiltered)
            {
                Console.WriteLine(name);
            }
            //xample2
            var students = Collections.FetchStudents();
            var result = from student in students  //query expression to use linq 
                              group student by student.CollegeName="MBM" into studentGroup
                              orderby studentGroup.Key 
                              select studentGroup; 
            foreach (var x in result)
            {
                System.Console.WriteLine(x.Key);
                foreach (var s in x)
                {
                    System.Console.WriteLine("--" + s.Name);
                }
            }
        }
    }
}
