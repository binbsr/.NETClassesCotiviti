namespace LinQ

{
    using System;
    using System.Collections.Generic;

public class Collections

    {
        public static List<Student> GetListOfStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { RollNumber = 1, Name = "Shreya", CollegeName = "Trinity", Dob = DateTime.Parse("1994/01/01"), FacultyId=22 });
            students.Add(new Student { RollNumber = 2, Name = "Sristi", CollegeName = "MM", Dob = DateTime.Parse("1990/12/11"), FacultyId =23 });
            students.Add(new Student { RollNumber = 3, Name = "Arya", CollegeName = "MM", Dob = DateTime.Parse("1991/04/06") ,FacultyId =23});
            students.Add(new Student { RollNumber = 4, Name = "Paul", CollegeName = "Kantipur", Dob = DateTime.Parse("1992/05/21"),FacultyId =24 });
            students.Add(new Student { RollNumber = 5, Name = "Rita", CollegeName = "Dhulikhel", Dob = DateTime.Parse("1990/09/17") ,FacultyId =25});
            return students;
 
        }

         public static List<Faculty> GetListOfFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            faculties.Add(new Faculty { Id = 22, FacultyName = "Computer", HOD="Niitin Malla"});
            faculties.Add(new Faculty { Id = 23, FacultyName = "Science", HOD="Ram"});
            faculties.Add(new Faculty { Id = 24, FacultyName = "Physic", HOD="Sita"});
            return faculties;
 
        }
    }
}