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
            students.Add(new Student { rollNo = 1, Name = "bishnu", CollegeName = "united", Dob = DateTime.Parse("1994/12/11") });
            students.Add(new Student { rollNo = 1, Name = "bisnu", CollegeName = "gems", Dob = DateTime.Parse("1996/12/11") });
            students.Add(new Student { rollNo = 1, Name = "hari", CollegeName = "prime", Dob = DateTime.Parse("1997/12/11") });
            students.Add(new Student { rollNo = 1, Name = "prasad", CollegeName = "ccrc", Dob = DateTime.Parse("1993/12/11") });
            students.Add(new Student { rollNo = 1, Name = "lali", CollegeName = "mbm", Dob = DateTime.Parse("1993/12/11") });
            return students;
        }
    }
}