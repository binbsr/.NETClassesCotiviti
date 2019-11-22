using System;
using System.Collections.Generic;

    public class Collections
    {
        public static List<Student> FetchStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { rollNo = 1, Name = "Ram", CollegeName = "Trinity", Dob = DateTime.Parse("1990/12/11") });
            students.Add(new Student { rollNo = 2, Name = "bishnu", CollegeName = "united", Dob = DateTime.Parse("1994/12/11") });
            students.Add(new Student { rollNo = 3, Name = "bisnu", CollegeName = "gems", Dob = DateTime.Parse("1996/12/11") });
            students.Add(new Student { rollNo = 4, Name = "hari", CollegeName = "MBM", Dob = DateTime.Parse("1997/12/11") });
            students.Add(new Student { rollNo = 5, Name = "prasad", CollegeName = "gems", Dob = DateTime.Parse("1993/12/11") });
            students.Add(new Student { rollNo = 6, Name = "lali", CollegeName = "MBM", Dob = DateTime.Parse("1993/12/11") });
            return students;
        }
    }