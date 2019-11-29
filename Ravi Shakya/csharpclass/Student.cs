// using System;
//     public class Student
//         {
//             // public Student ()// instance constructor
//             //  {
//             //      Console.WriteLine ("Its me instance constructor");
//             //  } 
            
          
//             static Student ()  //static constructor
//             {
//                 Console.WriteLine ("Its me static constructor");

//             }

//             // private Student()
//             // {

//             // }
//         public int RollNo {get; set;} //RollNo is instance member
//         public string Name {get; set;}
//         public static string Address {get; set;}

//          public static string CollegeName  {get; set;}
//         public string Stream {get; set;}
//         public DateTime Dob {get; set;}

//         public static string PrintStudentDetails()
//         {
            
//             return $"{CollegeName}, {Address}";
//         }
//     }

using System;

public class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public string CollegeName { get; set; }
    public DateTime Dob { get; set; }

    public int FacultyID{get; set;}
}
