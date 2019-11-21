using System;
using System.Collections.Generic;
public class Student {

    public int RollNo { get; set; } //instance member: as can be used by the instance of this class
    public string Name { get; set; }
    public static string Address { get; set; }
    public string CollegeName { get; set; }
    //when defined static the variable can be accessed through
    //out the program with same value, can be accesse through class(class.variable) but not through objects
    public string Stream { get; set; }
    public DateTime Dob { get; set; }
}

public class Collections {
    public static List<Student> FetchStudent ()
     {
        List<Student> students = new List<Student> ();
        students.Add (new Student { RollNo = 1, Name = "Sristi", CollegeName = "KU", Dob = DateTime.Parse ("1990-12-12") });
        students.Add (new Student { RollNo = 2, Name = "Ayushma", CollegeName = "KU", Dob = DateTime.Parse ("1991-12-12") });
        students.Add (new Student { RollNo = 3, Name = "Shreya", CollegeName = "KU", Dob = DateTime.Parse ("1992-12-12") });
        students.Add (new Student { RollNo = 4, Name = "Bishnu", CollegeName = "TU", Dob = DateTime.Parse ("1993-12-12") });
        return students;
    }

}