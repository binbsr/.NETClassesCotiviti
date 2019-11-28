using System;
using System.Collections.Generic;

public class Collections
{
    public static List<Student> FetchStudents()
    {
        List<Student> students = new List<Student>();
        
        students.Add(new Student { RollNo = 1, Name = "Ram", CollegeName = "Trinity", Dob = DateTime.Parse("1990/12/11"), FacultyId = 23 });
        students.Add(new Student { RollNo = 2, Name = "bishnu", CollegeName = "MBM", Dob = DateTime.Parse("1990/12/12"), FacultyId = 22 });
        students.Add(new Student { RollNo = 3, Name = "Ramesh", CollegeName = "St. Xaviers", Dob = DateTime.Parse("1999/4/11"), FacultyId = 25 });
        students.Add(new Student { RollNo = 4, Name = "John", CollegeName = "St. Xaviers", Dob = DateTime.Parse("1987/2/11"), FacultyId = 23 });
        students.Add(new Student { RollNo = 5, Name = "Rita", CollegeName = "MBM", Dob = DateTime.Parse("1989/9/11"), FacultyId = 24 });
        students.Add(new Student { RollNo = 6, Name = "Shreya", CollegeName = "MBM", Dob = DateTime.Parse("1992/3/11"), FacultyId = 25 });
        
        return students;
    }
    public static List<Faculty> FetchFaculties()
    {
        List<Faculty> faculties = new List<Faculty>();
        
        faculties.Add(new Faculty { Id = 23, FacultyName = "CS", HOD = "Suraj Dai"});
        faculties.Add(new Faculty { Id = 22, FacultyName = "CS", HOD = "Pala"});
        faculties.Add(new Faculty { Id = 24, FacultyName = "CS", HOD = "Suraj Shrestha"});
        faculties.Add(new Faculty { Id = 25, FacultyName = "GEO", HOD = "Suraj Babu"});
        faculties.Add(new Faculty { Id = 26, FacultyName = "GEO", HOD = "Suraj Joshi"});
        
        return faculties;
    }
}