//  using System;
//  using System.Collections.Generic;
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
using System.Collections.Generic;

namespace LINQ
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public string FacultyHead { get; set; }

    } 
}
