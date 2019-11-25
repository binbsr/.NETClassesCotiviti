using System;
using System.Collections.Generic;
using LINQ;

public class Collections
    {
        public static List<Student> FetchStudents()
        {
            List<Student> students = new List<Student>();
           students.Add(new Student { rollNo = 1, Name = "Ram", CollegeName = "Trinity", Dob = DateTime.Parse("1990/12/11") , facultyId = 12});
        students.Add(new Student { rollNo = 2, Name = "bishnu", CollegeName = "MBM", Dob = DateTime.Parse("1990/12/12") ,facultyId = 12});
        students.Add(new Student { rollNo = 3, Name = "Ramesh", CollegeName = "St. Xaviers", Dob = DateTime.Parse("1999/4/11") ,facultyId = 13});
        students.Add(new Student { rollNo = 4, Name = "John", CollegeName = "St. Xaviers", Dob = DateTime.Parse("1987/2/11") ,facultyId = 13});
        students.Add(new Student { rollNo = 5, Name = "Rita", CollegeName = "MBM", Dob = DateTime.Parse("1989/9/11"),facultyId = 14 });
        students.Add(new Student { rollNo = 6, Name = "Shreya", CollegeName = "MBM", Dob = DateTime.Parse("1992/3/11") ,facultyId = 14});
            return students;
        }

            public static List<Faculty> fetchFaculty()
        {
            List<Faculty> faculties = new List<Faculty>();
        faculties.Add(new Faculty { Id = 12, facultyName = "Computer", HOD = "Nitin Dai"});
        faculties.Add(new Faculty { Id = 13, facultyName = "Science", HOD = "Pala"});
        faculties.Add(new Faculty { Id = 14, facultyName = "Commerce", HOD = "Nitin"});
            return faculties;
        }
    }