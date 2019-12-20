using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Models {
    public class Employees {
        public int Id { get; set; }
        //public string Designation{get; set;}

        //[Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        //public double Salary{get; set;}  

        //[DataType(DataType.Date)]
        //[Display(Name = "Date of Birth")] //Yo display huncha UI if not then the variable name itself gets displayed
        public DateTime Dob { get; set; }
        // public int DepartmentId {get; set;}
        //public Department Department{get; set;} //this is mandatory this helps in navigation
        public int? DepartmentId { get; set; }

        public Department Department { get; set; }

    }

}