using System;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models {
    public class Employee {
        public int Id { get; set; }
        //Data Annotation
       // [Required (ErrorMessage = "First Name cannot be empty")]

        public string FirstName { get; set; }

       // [Required (ErrorMessage = "Last Name cannot be empty")]
        public string LastName { get; set; }

       // [DataType (DataType.Date)]
       // [Display (Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        public int DepartmentId{get;set;}
        public Department Department{get;set;}

    }
}