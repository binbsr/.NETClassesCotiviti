using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCDemo.Models {
    public class EmployeeViewModel {
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
        public string Name{get; set;}
        

        public SelectList DD_Department{get;set;}

    }
}