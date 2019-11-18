using System;
using System.Collections.Generic;

namespace Students
{
    public class AddStudent
    {
        // private string name;
        List<string> studentlist = new List<string>();
        public void addStudentInfo(string sname)
        {
            studentlist.Add(sname);
            Console.WriteLine("Student info added for " + sname + "\n");

        }

        public void getStudentInfo()
        {
            foreach (var s in studentlist)
            {
                Console.WriteLine(s);
            }


        }

    }

}
