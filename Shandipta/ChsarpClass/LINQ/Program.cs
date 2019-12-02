using System;
using System.Linq;
using System.Collections.Generic;

//imperative and declaratative programming language

namespace LINQ
{



    class Program
    {
        public void test()
    //    static void Main(string[] args)
        {
            //     LINQPrac lP = new LINQPrac();
            //     lP.LINQ(20, 30, 31, 32, 50);
            //     Console.WriteLine();
            //     var col = Collections.StudentDetails();
            //     foreach (var cc in col)
            //     {
            //         Console.WriteLine($"{cc.rollNo} {cc.name} {cc.gender}");
            //     }

            //     var students = from std in col
            //                    group std by std.rollNo into studentGroup
            //                    orderby studentGroup.Key
            //                    select studentGroup;
            //     foreach (var s in students)
            //     {
            //         Console.Write(s.Key);

            //         foreach (var ss in s)
            //         {
            //             Console.Write($"-> {ss.name}, {ss.gender}");
            //             Console.WriteLine();
            //         }
            //     }


            //     var y = from student in col
            //             where student.gender == "Female"
            //             orderby student.name
            //             select new { student.rollNo, student.name, student.gender };
            //     var z = col.Where(col => col.gender == "Female")
            //     .OrderBy(col => col.name).Select(col => new { col.rollNo, col.name, col.gender });

            //     foreach (var a in z)
            //     {
            //         Console.WriteLine($"{a.rollNo} {a.name} {a.gender}");
            //     }

            //     var studentsGroupByCollege = from student in col
            //                                  group student by student.gender into studentsGroup
            //                                  where studentsGroup.Count() <= 2
            //                                  orderby studentsGroup.Key
            //                                  select studentsGroup;


            //     //std.Where(std => std.CollegeName == "Pinnacle").Select(x => new{x.RollNo, x.Name});

            //     /*     Console.WriteLine($"Roll No.        Name");
            //          foreach (var n in y)
            //          {
            //              Console.WriteLine($"\t {n.RollNo}      {n.Name}");
            //          }
            //   */
            //     Console.WriteLine("Students by college");
            //     foreach (var studs in studentsGroupByCollege)
            //     {
            //         Console.WriteLine($"{studs.Key}");
            //         foreach (var stu in studs)
            //         {
            //             Console.WriteLine($"{stu.rollNo} - {stu.name}");
            //         }
            //     }
            //joining 
            var faculties = Collections.FacultyDetails();
            var students02 = Collections.StudentDetails();
            var depStudents = from student in students02
                              join faculty in faculties on student.facultyId equals faculty.ID
                              select new { Department = faculty.FacultyName, faculty.HOD, St = student }; //St holds object of StudentClass
            var depStudentGroupedByFacultyId = from x in depStudents
                                               group x by x.Department;

            foreach (var item in depStudentGroupedByFacultyId)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var s in item)
                {
                    Console.WriteLine($"\t{s.St.rollNo} - {s.St.name}");
                }
            }



        }



    }

}