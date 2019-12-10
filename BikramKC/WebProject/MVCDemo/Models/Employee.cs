using System;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Employee
    {
        [Display( Name="Name")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

    }
}