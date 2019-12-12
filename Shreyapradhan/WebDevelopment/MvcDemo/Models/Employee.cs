using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Models
{
    public class Employee
  {
    public int Id {get;set;}
    [Required(ErrorMessage="First name can not be empty")]
   
    public string FirstName {get;set;}

    [Required(ErrorMessage="Last name can not be empty")]
    public string LastName {get;set;}

    [DataType(DataType.Date)]
    [Display(Name="Date of Birth")]
    public DateTime DOB {get;set;}

    public int? DepartmentId{get;set;}
    public Department Department{get;set;}  // navigation property

   }

}
