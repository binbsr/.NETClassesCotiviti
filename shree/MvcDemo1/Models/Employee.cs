using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }       
        public string FirstName { get; set; }       
        public string LastName { get; set; }       
        public DateTime DOB { get; set; }        
        public int? DepartmentId{get;set;}      // here ? represents nullable value
        public Department Department{get;set;}
 
    }
}