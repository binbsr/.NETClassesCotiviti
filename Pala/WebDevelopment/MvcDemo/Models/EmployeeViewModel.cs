

using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcDemo.Models
{
    public class EmployeeViewModel
    {
    public int Id { get; set;}
    //[Required(ErrorMessage="First Name cannot be empty!!")]//Data annotations
    [Display(Name="FirstName")]
    public string FirstName { get; set;}
    //[Required(ErrorMessage="Last Name cannot be empty!!")]//Data annotations
    [Display(Name="LastName")]
    public string LastName { get; set;}
    [Display(Name="Date of Birth")]
    public DateTime DOB { get; set;}
    public int DepartmentId {get;set;}
    public SelectList DD_Departments {get;set;}
    [Display(Name="DepartmentName")]
    public string DepartmentName {get;set;}
    }

}