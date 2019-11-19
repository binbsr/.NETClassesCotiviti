using System;

public class Student
{
   /*
    public Student() {
        Console.WriteLine("Its me instance constructor");
    }*/

    //public Student(string name) {Name =name;}
    
    // static constructor doesnot have parameter and it is call once at the begining while creating 1st object
    static Student()
    {
        Console.WriteLine("Its me static constructor");
    }


// private constructor prevent object instances.
    private Student()
    {

    }
    // instance properties and static property
    public int RollNo { get; set; }
    public string Name { get; set; }
    public static string Address { get; set; }
    public static string CollegeName{get; set;}
    public string Stream { get; set; }
    public DateTime Dob { get; set; }

    //static method must have static data
    public static string PrintStudentDetails()
    {
       
        return ($"{CollegeName} , {Address}");
    }

}