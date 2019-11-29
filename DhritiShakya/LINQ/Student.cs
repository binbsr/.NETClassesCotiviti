
using System;
using System.Collections;
using System.Collections.Generic;

public class Student
{
    public int rollNo{get;set;}
    public string name{get;set;}
    public string address{get;set;}
    public string Collegename{get;set;}
    public DateTime dob{get;set;}

    public int facultyID{get;set;}
}

public class Collections1
{
    public static List<Student> FetchStudents()
    {
         //Example2
            List<Student> students=new List<Student>();
            students.Add(new Student{rollNo=1,name="Ram",address="Patan",Collegename="Trinity",dob=DateTime.Parse("1990/01/01"),facultyID=22});
            students.Add(new Student{rollNo=2,name="Shyam",address="Mangalbazar",Collegename="St.xaviers",dob=DateTime.Parse("1990/01/01"),facultyID=25});
            students.Add(new Student{rollNo=3,name="Gita",address="Pulchwok",Collegename="ENG",dob=DateTime.Parse("1990/01/01"),facultyID=22});
            students.Add(new Student{rollNo=4,name="Hari",address="kupundole",Collegename="ENG",dob=DateTime.Parse("1990/01/01"),facultyID=25});
            students.Add(new Student{rollNo=5,name="Sita",address="Hattisar",Collegename="ENG",dob=DateTime.Parse("1990/01/01"),facultyID=22});
            students.Add(new Student{rollNo=6,name="Mita",address="Durbarmarg",Collegename="ENG",dob=DateTime.Parse("1990/01/01"),facultyID=25});
            students.Add(new Student{rollNo=7,name="Rita",address="New Road",Collegename="ENG",dob=DateTime.Parse("1990/01/01"),facultyID=22});
            
       return students;

    }
}