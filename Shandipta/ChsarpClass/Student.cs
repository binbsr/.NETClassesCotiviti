using System;
namespace Collection
{
    public class Student
    {
        public int RollNo {get;set;}
        public string Name {get;set;}
        public static string Address{get;set;}//all instance of this class will have this static address
        public string Stream{get;set;}
        public DateTime dob {get;set;}
        public static string CollegeName{get;set;}

        public static string PrintStudentDetails(){
            return $"{CollegeName} {Address}"; //variables of a static class should also be static
        }

      //  if each and evey mebmer of a class is satatic then it make sense to make a class static
      //static constructor
      //singalton pattern use static constructors

      static Student(){
          Console.WriteLine("Static Constructor");
      }

      //private constructor
      //prevent to create instace of that class
      private Student(){
          
      }
      //instantiation in c#
      //useability,commoness
      //one class cannot inherit multiple class
      //multiple interface can be implemented but bass class need to be only one
    }



}
