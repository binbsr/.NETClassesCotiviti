using System;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "First Name *")]
        [Required(ErrorMessage = "First Name cannot be empty.")]        
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth *")]
        [Required(ErrorMessage = "DOB should not be empty")]
        public DateTime DOB { get; set; }

    }
}