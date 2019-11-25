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
        public int FactultyId { get; set; }

    }

    public class Collections
    {
        public static List<Student> FetchStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { RollNo = 1, Name = "Ram", CollegeName = "Trinity", Dob = DateTime.Parse("1990/12/11"), FactultyId=10 });
            students.Add(new Student { RollNo = 2, Name = "bishnu", CollegeName = "gems", Dob = DateTime.Parse("1994/12/11"), FactultyId = 10 });
            students.Add(new Student { RollNo = 3, Name = "bisnu", CollegeName = "gems", Dob = DateTime.Parse("1996/12/11"), FactultyId = 20 });
            students.Add(new Student { RollNo = 4, Name = "hari", CollegeName = "gems", Dob = DateTime.Parse("1997/12/11"), FactultyId = 20 });
            students.Add(new Student { RollNo = 5, Name = "prasad", CollegeName = "mbm", Dob = DateTime.Parse("1993/12/11"), FactultyId = 30 });
            students.Add(new Student { RollNo = 6, Name = "lali", CollegeName = "mbm", Dob = DateTime.Parse("1993/12/11"), FactultyId = 30 });
            return students;
        }
        public static List<Faculty> FetchFacutly()
        {
            List<Faculty> faculties = new List<Faculty>();
            faculties.Add(new Faculty { FacultyId = 10, FacultyName = "Science", FacultyHead = "Ram prasad" });
            faculties.Add(new Faculty { FacultyId = 20, FacultyName = "Management", FacultyHead = "Hari" });
            faculties.Add(new Faculty { FacultyId = 30, FacultyName = "English", FacultyHead = "Krishna" });
            faculties.Add(new Faculty { FacultyId = 40, FacultyName = "Humanities", FacultyHead = "Sita" });
            return faculties;
        }
    }
    
}