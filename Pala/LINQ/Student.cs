using System;
using System.Collections.Generic;

namespace LINQ
{
    public class Student
    {
        public int rollNo { get; set; }
        public string Name { get; set; }
        public string stream { get; set; }
        public string CollegeName { get; set; }
        public DateTime Dob { get; set; }
    }

    public class Collections
    {
        public static List<Student> FetchStudents()
        {
            List<Student> students = new List<Student>();
           students.Add(new Student { rollNo = 1, Name = "Ram", CollegeName = "Trinity", Dob = DateTime.Parse("1990/12/11") });
        students.Add(new Student { rollNo = 2, Name = "bishnu", CollegeName = "MBM", Dob = DateTime.Parse("1990/12/12") });
        students.Add(new Student { rollNo = 3, Name = "Ramesh", CollegeName = "St. Xaviers", Dob = DateTime.Parse("1999/4/11") });
        students.Add(new Student { rollNo = 4, Name = "John", CollegeName = "St. Xaviers", Dob = DateTime.Parse("1987/2/11") });
        students.Add(new Student { rollNo = 5, Name = "Rita", CollegeName = "MBM", Dob = DateTime.Parse("1989/9/11") });
        students.Add(new Student { rollNo = 6, Name = "Shreya", CollegeName = "MBM", Dob = DateTime.Parse("1992/3/11") });
            return students;
        }
    }
}