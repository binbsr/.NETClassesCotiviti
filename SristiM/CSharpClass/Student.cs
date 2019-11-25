

using System;

public  class Student//static class should have evth inside static
{
    //public int RollNo{get;set;}//instance member: as can be used by the instance of this class
    //public string Name{get;set;}
    public static string Address{get;set;}
    public static string CollegeName{get;set;}
    //when defined static the variable can be accessed through
    //out the program with same value, can be accesse through class(class.variable) but not through objects

    //public string Stream{get;set;}

    //public DateTime Dob{get;set;}

    public static string PrintStudentDetails()
    //static method , it should have static members
    {        
        return $"{Address},{CollegeName}";
    }

    public Student(){
        Console.WriteLine("Its me instance Constructor");

    }//instance constructor

    //static Student(string name){Name=name;}//static constructor

    static Student()
    {
        Console.WriteLine("Its me static constructor");
    }

    //private Student()//private constructor, prevents instantiation of the class, no object can be created
    //{    }
    

}
