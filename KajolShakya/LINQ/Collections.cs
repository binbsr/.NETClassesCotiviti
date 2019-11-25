
using System;
using System.Collections.Generic;




public class Collections
{
    public static List<Student> FetchStudents()
    {
        List<Student> students = new List<Student>();

        students.Add(new Student {RollNo = 1, Name = "Kajol", CollegeName = "Pinnacle", Dob = DateTime.Parse("1990/12/11"), FacultyID = 23});
        students.Add(new Student {RollNo = 2, Name = "Dhriti", CollegeName = "Trinity", Dob = DateTime.Parse("1990/12/13")});
        students.Add(new Student {RollNo = 3, Name = "Bikram", CollegeName = "BHS", Dob = DateTime.Parse("1990/12/14")});
        students.Add(new Student {RollNo = 4, Name = "Ayushma", CollegeName = "Unique", Dob = DateTime.Parse("1990/12/15")});
        
        return students;
    }

    public static List<Faculty> FetchFaculties()
    {
        List<Faculty> faculties = new List<Faculty>();

        faculties.Add(new Faculty {ID = 23, FacultyName = "CS", HOD = "Suraj"});
        faculties.Add(new Faculty {ID = 22, FacultyName = "CS", HOD = "Suraj"});
        faculties.Add(new Faculty {ID = 24, FacultyName = "DC", HOD = "Suraj"});
        faculties.Add(new Faculty {ID = 25, FacultyName = "DS", HOD = "Suraj"});
        faculties.Add(new Faculty {ID = 26, FacultyName = "DS", HOD = "Suraj"});
        
        
        return faculties;
    }
}
