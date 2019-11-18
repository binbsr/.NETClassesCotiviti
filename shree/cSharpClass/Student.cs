using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpClass
{
    public static class Student         // this is static class - need all member of class must be static and does not allow to create instant
    {
       // public int RollNo { get; set; }         // instant member - which is used by instant only
        //public string Name { get; set; }
        public static string Address { get; set; }      // Address is static member
        //public string Stream { get; set; }
        public static string CollegeName { get; set; }
        //public DateTime Dob { get; set; }           // DateTime is structure give by framework

        public static string PrintStudentDetails()          // this is static method so static data should be used
        {
            
            return $"{CollegeName}, {Address}";
        }

        //public Student() { }
        static Student() { }
    }

    public class Student1    
    {
        public int RollNo { get; set; }        
        public string Name { get; set; }
        public static string Address { get; set; }  
        public string Stream { get; set; }
        public static string CollegeName { get; set; }
        public DateTime Dob { get; set; }           

        public static string PrintStudentDetails()  
        {

            return $"{CollegeName}, {Address}";
        }

       // public Student1()
        //{
         //   Console.WriteLine("Its implementation of instant constructor");
        //}

        private Student1()      // private constructor doesn't allow to create instant
        {

        }
        public Student1(string name) { name = name; }

        static Student1()
        {
            Console.WriteLine("Its implementation of static constructor");
        }
    }
}
