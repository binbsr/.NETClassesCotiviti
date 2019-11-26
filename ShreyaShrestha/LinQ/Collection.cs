using System;
using System.Collections.Generic;
namespace LinQ
{

    public class Collections
    {

        public static List<Student> GetListOfStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { RollNumber = 1, Name = "Shreya", Address = "Trinity", Dob = DateTime.Parse("1994/01/01"), FacultyId = 1 }); //student object
            students.Add(new Student { RollNumber = 2, Name = "Sristi", Address = "MM", Dob = DateTime.Parse("1990/12/11"), FacultyId = 2 });
            students.Add(new Student { RollNumber = 3, Name = "Arya", Address = "MM", Dob = DateTime.Parse("1991/04/06"), FacultyId = 1 });
            students.Add(new Student { RollNumber = 6, Name = "Arohan", Address = "MM", Dob = DateTime.Parse("1991/04/06"), FacultyId = 3 });
            students.Add(new Student { RollNumber = 4, Name = "Paul", Address = "Kantipur", Dob = DateTime.Parse("1992/05/21"), FacultyId = 4 });
            students.Add(new Student { RollNumber = 5, Name = "Rita", Address = "Dhulikhel", Dob = DateTime.Parse("1990/09/17"), FacultyId = 5 });
            return students;

        }

        public static List<Faculty> FetchFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            faculties.Add(new Faculty { Id = 1, FacultyName = "Ge", Hod = "Shreya" }); 
            faculties.Add(new Faculty { Id = 2, FacultyName= "CE", Hod = "Sristi" });
            faculties.Add(new Faculty { Id = 3, FacultyName = "ENE", Hod = "Arya" });
            faculties.Add(new Faculty { Id = 6, FacultyName = "ME", Hod = "Arohan" });
            faculties.Add(new Faculty { Id = 4, FacultyName = "Media", Hod = "Paul" });
            faculties.Add(new Faculty { Id = 5, FacultyName= "Law", Hod = "Rita" });
            return faculties;

        }
    }

}