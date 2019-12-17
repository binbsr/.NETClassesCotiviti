

using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Models
{
    public class Employee
    {
    public int Id { get; set;}
    [Required(ErrorMessage="First Name cannot be empty!!")]//Data annotations
    public string FirstName { get; set;}
    [Required(ErrorMessage="Last Name cannot be empty!!")]//Data annotations
    public string LastName { get; set;}
    [Display(Name="Date of Birth")]
    public DateTime DOB { get; set;}
    public int? DepartmentId{get;set;}
    public Department Department{get;set;}
    }
}