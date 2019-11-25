using System;
public  class Student // class can be static if all the members are static
{
    //public int rollNo {get;set;}  // instance member
    public   string name {get;set;}
    public static string address {get;set;} //static member
    //public string stream {get;set;}
     //public DateTime dob {get;set;}
     public static string collegName{get;set;} 


     public Student()
     {
         Console.WriteLine("Its me static constructor");
     }

     /*private Student()  // does not allow instantiation
     {

     }*/

     //public Student(string Name){name=Name}

     static Student()
     {
         Console.WriteLine("Its me static constructor");
     }


     public static string PrintStudentDetails() // static method uses only static member or use object 
     {
        
         return $"{address}";
     }
}
