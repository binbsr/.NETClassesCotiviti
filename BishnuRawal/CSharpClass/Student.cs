using System;
public class Student
{
    // public Student() 
    // { 
    //     //Console.WriteLine("Its me instance constructor");
    // }
    static Student() 
    {
        Console.WriteLine("Its me static constructor");
    }

    public Student(string n)
    {

    }

    public int RollNo { get; set; }
    public string Name { get; set; }
    public static string Address { get; set; }
    public static string CollegeName { get; set; }
    public string Stream { get; set; }
    public DateTime Dob { get; set; }

    public static string PrintStudentDetails()
    {
        return $"{CollegeName}, {Address}";
    }
}