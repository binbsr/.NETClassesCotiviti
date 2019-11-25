using System;

public class Student
{   
//     public Student()
// {
//     Console.WriteLine("This is instance constructor");
// }

static Student()
{
   Console.WriteLine("This is static constructor");//static constructor will get called first when an instance of an class is created in main method
}
    public int rollNo;
    public string name;
    public string address;
    public string stream;
    public DateTime dob;

    public  Student(string n)
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