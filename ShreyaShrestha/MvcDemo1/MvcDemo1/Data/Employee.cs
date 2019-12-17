using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo1.Data
{
    public class Employee
    {
        public int Id { get; set; }
        //public string Designation{get; set;}
        public string FirstName { get; set; }

        public string LastName { get; set; }
        //public double Salary{get; set;}  
        public DateTime Dob { get; set; }
    }
}
