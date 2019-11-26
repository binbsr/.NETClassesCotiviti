using System;
using System.Collections.Generic;



 
public class Collections
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

    

    public static List<Faculty> FetchFaculties()
    {
        List<Faculty> faculties = new List<Faculty>();
 
        faculties.Add(new Faculty {ID = 23, facultyName = "CS", HOD = "Suraj"});
        faculties.Add(new Faculty {ID = 22, facultyName = "CS", HOD = "Dhriti"});
        faculties.Add(new Faculty {ID = 24, facultyName = "DC", HOD = "kajol"});
        faculties.Add(new Faculty {ID = 25, facultyName = "DS", HOD = "Sur"});
        faculties.Add(new Faculty {ID = 26, facultyName = "DS", HOD = "raj"});
        
        
        return faculties;
    }
}
