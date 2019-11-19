using System;
public  class Student // static class declared only when all properties and method are static
{
    //public Student()
    //{
    //  Console.WriteLine("It is instance constructor");
    //}

        static Student()//called only once first time by object
    {
        Console.WriteLine("It is a static constructor");
    }
    private Student(){}//doent allow to create object 
    public int rollNo { get;set; }//instance member accessed by instance
    public string name {get; set;}
    public static string address {get; set;}//static property accessed by class
    public static string CollegeName {get; set;}
    //public string stream {get; set;}
    public DateTime dob {get; set;}

    public static string PrintStudentDetails()//only static value accessed in static method
    {
        return $"{CollegeName} , {address}";
    }
}