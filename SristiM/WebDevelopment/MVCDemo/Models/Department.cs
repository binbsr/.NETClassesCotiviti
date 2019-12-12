using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models {
    public class Department {
        public int Id { get; set; }
        //Data Annotation
        //[Required (ErrorMessage = "First Name cannot be empty")]

        public string Name { get; set; }

        //[Required (ErrorMessage = "Last Name cannot be empty")]
        public string Location  { get; set; }

       public List<Employee> Employees{get;set;}
    }
}