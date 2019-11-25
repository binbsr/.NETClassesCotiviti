using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{

    public class Collections
    {
        public static List<Student> StudentDetails()
        {
            List<Student> std = new List<Student>();
            std.Add(new Student { name = "Willow", rollNo = 3, gender = "Female", facultyId = 21 });
            std.Add(new Student { name = "Anna", rollNo = 1, gender = "Female", facultyId = 21 });
            std.Add(new Student { name = "James", rollNo = 2, gender = "Male", facultyId = 22 });
            return std;

        }
        public int facultyId { get; set; }

        public static List<Faculty> FacultyDetails()
        {
            List<Faculty> fac = new List<Faculty>();
            fac.Add(new Faculty { ID = 21, HOD = "Bishnu", FacultyName = "Visual Basic" });
            fac.Add(new Faculty { ID = 22, HOD = "Suraj", FacultyName = "Submission" });
            return fac;
        }
    }
}