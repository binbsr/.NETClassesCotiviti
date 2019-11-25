using System;
using System.Collections.Generic;
 
namespace LinQ
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string CollegeName { get; set; }
        public string Stream { get; set; }
        public DateTime Dob { get; set; }
 
    }
    public class Collections
    {
        public static List<Student> GetListOfStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { RollNumber = 1, Name = "Shreya", CollegeName = "Trinity", Dob = DateTime.Parse("1994/01/01") });
            students.Add(new Student { RollNumber = 2, Name = "Sristi", CollegeName = "MM", Dob = DateTime.Parse("1990/12/11") });
            students.Add(new Student { RollNumber = 3, Name = "Arya", CollegeName = "MM", Dob = DateTime.Parse("1991/04/06") });
            students.Add(new Student { RollNumber = 4, Name = "Paul", CollegeName = "Kantipur", Dob = DateTime.Parse("1992/05/21") });
            students.Add(new Student { RollNumber = 5, Name = "Rita", CollegeName = "Dhulikhel", Dob = DateTime.Parse("1990/09/17") });
            return students;
 
        }
    }
 
}