using System;
using System.Collections.Generic;

public class Collections
{
    public static List<Student> FetchStudents()
    {
        List<Student> students = new List<Student>();

        students.Add(new Student{RollNo = 1,name ="Ram",address="Imadole",dob=DateTime.Parse("1990/01/01")}) ;
        students.Add(new Student{RollNo = 2,name ="Bikram",address="Thapathali",dob=DateTime.Parse("1989/01/01")});
        students.Add(new Student{RollNo = 3,name ="Kajol",address="Imadole",dob=DateTime.Parse("1989/02/29")}) ;

        return students;
    }
}
