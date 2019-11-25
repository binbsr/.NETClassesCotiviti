using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    public class Student
    {
        public string name { get; set; }
        public int rollNo { get; set; }
        public DateTime dob { get; set; }
        public string gender { get; set; }
        public string college { get; set; }

    }
    public class Collections
    {
        public List<Student> StudentDetails()
        {
            List<Student> std = new List<Student>();
            std.Add(new Student { name = "Willow", rollNo = 3, gender = "Female" });
            std.Add(new Student { name = "Anna", rollNo = 1, gender = "Female" });
            std.Add(new Student { name = "James", rollNo = 2, gender = "Male" });
            return std;

        }


    }

}