using System;
namespace StudentDetails
{
    public class Student
    {
        public Student()
        {
            Console.WriteLine("Its me instance Constructor");
        }
         static Student()
        {
            Console.WriteLine("Its me static Constructor");
        }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public static string CollegeName { get; set; }
        public string Stream { get; set; }
        public DateTime Dob { get; set; }

        public static string PrintStudentDetails()
        {
            return $"{CollegeName}";
        }

    }
}
