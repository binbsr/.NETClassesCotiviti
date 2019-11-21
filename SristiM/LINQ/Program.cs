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

            foreach (var name in namesFiltered) {
                Console.WriteLine (name);

            }

            //Example-2
            var students = Collections.FetchStudent ();
            var result = from student in students
            //where students.CollgeName="KU"
            group student by student.CollegeName into studentGroup
            orderby studentGroup.Key
            select studentGroup;

            foreach (var x in result) {
                //System.Console.WriteLine (x.Key);
                foreach (var s in x) {
                    System.Console.WriteLine (x.Key+"--" + s.Name);

                }

            }
        }
    }
}