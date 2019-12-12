using System;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Employee
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "First Name Can't be empty !!!")]

        public string FirstName {get; set;}

        [Required(ErrorMessage = "Last Name Can't be empty !!!")]
        public string LastName {get; set;}

        public DateTime DOB {get; set;}
    }
}
