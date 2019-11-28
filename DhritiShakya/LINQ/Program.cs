using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           // LINQ:Language Integrated Query
            string[] names={"Dhriti","Kajol","Bikram","Bishnu","Shahad","Ayushma"};
           var orderednames=names.OrderBy(x=>x);//x goes to x
           var namesfiltered=names.Where(x=>x.StartsWith("S"));
            foreach (string name in namesfiltered)
            {
                Console.WriteLine(name);
            }

           var students=Collections.FetchStudents();
            var result=from student in students group student by student.Collegename into Studentgroup
            orderby Studentgroup.Key
            select Studentgroup;
foreach (var x in result)
{
    Console.WriteLine(x.Key);
    foreach (var s in x)
            {
                Console.WriteLine("--"+s.name);
            }
}
           //joining
          var faculties= Collections.FetchFaculties();
           var depStudents=from student in students
                           join faculty in faculties on student.facultyID equals faculty.ID
                        select new {Department =faculty.facultyName,Student=student};

                        var deptStudentGroupedByFacultyId = from x in depStudents
                                                group  x by x.Department;
            foreach (var item in depStudents)
            {
                Console.WriteLine($"{item.Department} -{item.Student.name}");
            }
            foreach(var items in deptStudentGroupedByFacultyId)
            {
                Console.WriteLine($"{items.Key}");
                foreach(var item in items)
                {
                        Console.WriteLine($"{item.Student.rollNo}-{item.Student.name}");
                }
                
            }

            
           
                                                

        }
    }
}
        
