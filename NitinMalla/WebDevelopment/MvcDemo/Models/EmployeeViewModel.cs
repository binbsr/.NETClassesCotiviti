using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcDemo.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

         public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public DateTime DOB { get; set; }

        public string DepartmentId {get; set;}

        public SelectList DD_Departments {get; set;}

    }
}