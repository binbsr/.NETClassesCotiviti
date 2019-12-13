using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MvcDemo.Models
{
    public class EmployeeViewModel
  {
    public int Id {get;set;}
    [Required]
    [Display(Name="First name")]
    public string FirstName {get;set;}

    
    [Required]
    [Display(Name="Last name")]
    public string LastName {get;set;}

   [Display(Name="Date of Birth")]
    public DateTime DOB {get;set;}

    public int DepartmentId{get;set;}

    public SelectList DD_Departments{get;set;}

    [Display(Name="Department Name ")]
    public string DepartmentName { get; set; }
    }

}
