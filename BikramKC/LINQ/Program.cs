using System;
using System.Linq;
using System.Collections.Generic;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LiNQ language Integrated Query
            // Example 1
            string[] names = { "Bishnu", "Pawan", "Bikram", "Sristi", "Kajol" };
            var orderedNames = names.OrderBy(X => X);
            var namesStartswithB = names.Where(x => x.StartsWith('B'));
            foreach (var item  in namesStartswithB)
            {
                              
                Console.WriteLine(item);

            }
            // Example 2

            var jpt = StudentCollection.FetchStudents();
            var result = from Students in jpt group Students by Students.collegeName into stdGroup
            orderby stdGroup.Key
            select stdGroup;

        
    }
}
}
