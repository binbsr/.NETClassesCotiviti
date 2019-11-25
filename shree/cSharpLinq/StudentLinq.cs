using System;
using System.Collections.Generic;

namespace cSharpLinq
{
    public class Student
    {
        public int RollNo { get; set; }
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
            students.Add(new Student { RollNo = 1, Name = "Ram", CollegeName = "Trinity", Dob = DateTime.Parse("1990/12/11") });
            students.Add(new Student { RollNo = 2, Name = "bishnu", CollegeName = "gems", Dob = DateTime.Parse("1994/12/11") });
            students.Add(new Student { RollNo = 3, Name = "bisnu", CollegeName = "gems", Dob = DateTime.Parse("1996/12/11") });
            students.Add(new Student { RollNo = 4, Name = "hari", CollegeName = "gems", Dob = DateTime.Parse("1997/12/11") });
            students.Add(new Student { RollNo = 5, Name = "prasad", CollegeName = "mbm", Dob = DateTime.Parse("1993/12/11") });
            students.Add(new Student { RollNo = 6, Name = "lali", CollegeName = "mbm", Dob = DateTime.Parse("1993/12/11") });
            return students;
        }
    }
}